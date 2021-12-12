﻿using System.Collections.Generic;
using System.Linq;
using TA;
using static SolastaModApi.DatabaseHelper.DecisionPackageDefinitions;
using static SolastaModApi.DatabaseHelper.FactionDefinitions;
using static SolastaModApi.DatabaseHelper.FormationDefinitions;

namespace SolastaCommunityExpansion.Models
{
    internal static class EncountersSpawnContext
    {
        private static ulong EncounterId { get; set; } = 10000;

        private static readonly List<RulesetCharacterHero> Heroes = new List<RulesetCharacterHero>();

        private static readonly List<MonsterDefinition> SolastaMonsters = new List<MonsterDefinition>();

        internal static readonly List<RulesetCharacter> EncounterCharacters = new List<RulesetCharacter>();

        internal static bool HasStagedHeroes { get; set; }

        internal static void Load()
        {
            ServiceRepository.GetService<IInputService>().RegisterCommand(Settings.CTRL_SHIFT_E, 101, 304, 306, -1, -1, -1);
        }

        internal static void AddToEncounter(RulesetCharacterHero hero)
        {
            if (EncounterCharacters.Count < Settings.MAX_ENCOUNTER_CHARACTERS)
            {
                EncounterCharacters.Add(hero);
            }
        }

        internal static void AddToEncounter(MonsterDefinition monsterDefinition)
        {
            if (EncounterCharacters.Count < Settings.MAX_ENCOUNTER_CHARACTERS)
            {
                EncounterCharacters.Add(new RulesetCharacterMonster(monsterDefinition, 0, new RuleDefinitions.SpawnOverrides(), GadgetDefinitions.CreatureSex.Male));
            }
        }

        internal static void RemoveFromEncounter(int index)
        {
            if (index < EncounterCharacters.Count)
            {
                EncounterCharacters.RemoveAt(index);
            }
        }

        internal static List<MonsterDefinition> GetMonsters()
        {
            if (SolastaMonsters.Count == 0)
            {
                var monsterDefinitionDatabase = DatabaseRepository.GetDatabase<MonsterDefinition>();

                if (monsterDefinitionDatabase != null)
                {
                    foreach (var monsterDefinition in monsterDefinitionDatabase.Where(x => x.DungeonMakerPresence == MonsterDefinition.DungeonMaker.Monster))
                    {
                        SolastaMonsters.Add(monsterDefinition);
                    }

                    SolastaMonsters.Sort((a, b) => a.FormatTitle().CompareTo(b.FormatTitle()));
                }
            }

            return SolastaMonsters;
        }

        internal static List<RulesetCharacterHero> GetHeroes()
        {
            if (Heroes.Count == 0) 
            {
                var characterPoolService = ServiceRepository.GetService<ICharacterPoolService>();

                if (characterPoolService != null)
                {
                    foreach (var name in characterPoolService.Pool.Keys)
                    {
                        var filename = characterPoolService.BuildCharacterFilename(name.Substring(0, name.Length - 4));

                        characterPoolService.LoadCharacter(filename, out RulesetCharacterHero hero, out RulesetCharacterHero.Snapshot _);
                        Heroes.Add(hero);
                    }

                    Heroes.Sort((a, b) =>
                    {
                        var compareName = a.Name.CompareTo(b.Name);

                        if (compareName == 0)
                        {
                            compareName = a.SurName.CompareTo(b.SurName);
                        }

                        return compareName;
                    });
                }
            }

            return Heroes;
        }

        internal static void ConfirmStageEncounter()
        {
            var position = GetEncounterPosition();

            Gui.GuiService.ShowMessage(
                MessageModal.Severity.Attention2,
                "Message/&SpawnCustomEncounterTitle", 
                Gui.Format("Message/&SpawnCustomEncounterDescription", position.x.ToString(), position.x.ToString()),
                "Message/&MessageYesTitle", "Message/&MessageNoTitle",
                new MessageModal.MessageValidatedHandler(() => { StageEncounter(position); }), null);
        }

        private static int3 GetEncounterPosition()
        {
            var gameLocationService = ServiceRepository.GetService<IGameLocationService>();

            int x = (int)gameLocationService.GameLocation.LastCameraPosition.x;
            int z = (int)gameLocationService.GameLocation.LastCameraPosition.z;

            return new int3(x, 0, z);
        }

        private static void StageEncounter(int3 position)
        {
            var gameLocationCharacterService = ServiceRepository.GetService<IGameLocationCharacterService>();
            var gameLocationPositioningService = ServiceRepository.GetService<IGameLocationPositioningService>();
            var positions = new List<int3>();
            var formationPositions = new List<int3>();
            var sizeList = new List<RulesetActor.SizeParameters>();
            var characters = new List<GameLocationCharacter>();

            for (var ix = 0; ix < 4; ix++)
            {
                for (var iy = 0; iy < 4; iy++)
                {
                    formationPositions.Add(new int3(ix, 0, iy));
                }
            }

            HasStagedHeroes = false;

            foreach (var character in EncounterCharacters)
            {
                var gameLocationCharacter = gameLocationCharacterService.CreateCharacter(Settings.DM_CONTROLLER_ID, character, RuleDefinitions.Side.Enemy, new GameLocationBehaviourPackage
                {
                    BattleStartBehavior = GameLocationBehaviourPackage.BattleStartBehaviorType.DoNotRaiseAlarm,
                    DecisionPackageDefinition = IdleGuard_Default,
                    EncounterId = EncounterId++,
                    FormationDefinition = EncounterCharacters.Count > 1 ? Squad4 : SingleCreature
                });

                sizeList.Add(character.SizeParams);
                gameLocationCharacter.CollectExistingLightSources(true);
                gameLocationCharacter.RefreshActionPerformances();
                gameLocationCharacter.RulesetCharacter.SetBaseFaction(HostileMonsters);
                characters.Add(gameLocationCharacter);
                HasStagedHeroes = character is RulesetCharacterHero || HasStagedHeroes;
            }

            gameLocationPositioningService.ComputeFormationPlacementPositions(
                characters, position, LocationDefinitions.Orientation.North, formationPositions, CellHelpers.PlacementMode.Station, positions, sizeList, 25);

            for (var index = 0; index < positions.Count; index++)
            {
                gameLocationPositioningService.PlaceCharacter(characters[index], positions[index], LocationDefinitions.Orientation.North);
                gameLocationCharacterService.RevealCharacter(characters[index]);
            }

            Heroes.Clear();
            SolastaMonsters.Clear();
            EncounterCharacters.Clear();
            gameLocationCharacterService.RefreshAllCharacters();
        }
    }
}