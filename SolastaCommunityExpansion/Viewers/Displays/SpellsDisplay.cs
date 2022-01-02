﻿using ModKit;
using SolastaCommunityExpansion.Models;
using System.Collections.Generic;
using System.Linq;

namespace SolastaCommunityExpansion.Viewers.Displays
{
    internal static class SpellsDisplay
    {
        private const int SHOW_ALL = -1;

        private const int MAX_COLUMNS = 4;

        private const float PIXELS_PER_COLUMN = 225;

        private static int SpellLevelFilter { get; set; } = SHOW_ALL;

        private static bool Initialized { get; set; }

        private static readonly List<SpellDefinition> SortedRegisteredSpells = new List<SpellDefinition>();

        private static bool ExpandAllToggle { get; set; }

        private static readonly Dictionary<string, bool> SpellNamesToggle = new Dictionary<string, bool>();

        private static void RecacheSortedRegisteredSpells()
        {
            SortedRegisteredSpells.Clear();
            SortedRegisteredSpells.AddRange(SpellsContext.RegisteredSpells
                .Select(x => x.Key)
                .Where(x => SpellLevelFilter == SHOW_ALL || x.SpellLevel == SpellLevelFilter)
                .OrderBy(x => $"{x.SpellLevel} - {x.FormatTitle()}"));
        }

        internal static void DisplaySpells()
        {
            int intValue;
            bool toggle;

            if (!Initialized)
            {
                SpellsContext.RegisteredSpells.Keys
                    .Select(x => x.Name)
                    .ToList()
                    .ForEach(x => SpellNamesToggle.Add(x, false));

                RecacheSortedRegisteredSpells();

                Initialized = true;
            }

            UI.Label("");
            UI.Label(". You can individually assign each spell to any caster spell list or simply select the suggested set");
            UI.Label("");

            using (UI.HorizontalScope())
            {
                UI.Space(20);

                toggle = SpellsContext.AreAllSpellListsSelected();

                if (UI.Toggle("Select All", ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                {
                    SpellsContext.SwitchAllSpellLists(toggle);
                }

                toggle = SpellsContext.AreSuggestedSpellListsSelected();
                if (UI.Toggle("Select Suggested", ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                {
                    SpellsContext.SwitchSuggestedSpellLists(toggle);
                }
            }

            UI.Label("");

            using (UI.HorizontalScope())
            {
                UI.Space(20);

                intValue = SpellLevelFilter;
                if (UI.Slider("Spell level filter ".white() + "[-1 to display all spells]".italic().yellow(), ref intValue, SHOW_ALL, 9, SHOW_ALL, "L", UI.AutoWidth()))
                {
                    SpellLevelFilter = intValue;
                    RecacheSortedRegisteredSpells();
                }
            }

            UI.Label("");

            if (SortedRegisteredSpells.Count > 0)
            {
                using (UI.HorizontalScope())
                {
                    UI.Space(20);

                    ExpandAllToggle = SpellNamesToggle.Count == SpellNamesToggle.Count(x => x.Value);
                    toggle = ExpandAllToggle;
                    if (UI.Toggle("Expand All", ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                    {
                        ExpandAllToggle = toggle;
                        SpellNamesToggle.Keys.ToList().ForEach(x => SpellNamesToggle[x] = toggle);
                    }
                }
            }
            else
            {
                UI.Label($". No unofficial level {SpellLevelFilter} spells available".red().bold());
            }

            UI.Label("");

            foreach (var spellDefinition in SortedRegisteredSpells)
            {
                var spellName = spellDefinition.Name;
                var spellTitle = $"{spellDefinition.SpellLevel} - {spellDefinition.FormatTitle()}";

                toggle = SpellNamesToggle[spellName];
                if (UI.DisclosureToggle(spellTitle.yellow(), ref toggle, 200))
                {
                    SpellNamesToggle[spellName] = toggle;
                }

                if (SpellNamesToggle[spellName])
                {
                    DisplaySpell(spellDefinition);
                }

                UI.Label("");
            }
        }

        internal static void DisplaySpell(SpellDefinition spellDefinition)
        {
            UI.Label("");
            UI.Label($". {spellDefinition.FormatDescription()}");

            using (UI.HorizontalScope())
            {
                UI.Space(20);

                using (UI.VerticalScope())
                {
                    DisplaySpellListSelection(spellDefinition);
                }
            }
        }

        internal static void DisplaySpellListSelection(SpellDefinition spellDefinition)
        {
            var spellName = spellDefinition.Name;
            bool toggle;
            int columns;
            var current = 0;
            var spellListsTitles = SpellsContext.GetSpellLists.Keys;
            var spellLists = SpellsContext.GetSpellLists.Values;
            var spellListsCount = spellLists.Count;

            UI.Label("");

            using (UI.HorizontalScope())
            {
                toggle = SpellsContext.AreAllSpellListsSelected(spellDefinition);
                if (UI.Toggle("Select All", ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                {
                    SpellsContext.SwitchAllSpellLists(toggle, spellDefinition);
                }

                toggle = SpellsContext.AreSuggestedSpellListsSelected(spellDefinition);
                if (UI.Toggle("Select Suggested", ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                {
                    SpellsContext.SwitchSuggestedSpellLists(toggle, spellDefinition);
                }
            }

            UI.Label("");

            while (current < spellListsCount)
            {
                columns = MAX_COLUMNS;

                using (UI.HorizontalScope())
                {
                    while (current < spellListsCount && columns-- > 0)
                    {
                        var spellListDefinition = spellLists.ElementAt(current);
                        var spellListName = spellListDefinition.Name;
                        var spellListTitle = spellListsTitles.ElementAt(current);

                        toggle = Main.Settings.SpellSpellListEnabled[spellName].Contains(spellListName);
                        if (UI.Toggle(spellListTitle, ref toggle, UI.Width(PIXELS_PER_COLUMN)))
                        {
                            if (toggle)
                            {
                                Main.Settings.SpellSpellListEnabled[spellName].Add(spellListName);
                            }
                            else
                            {
                                Main.Settings.SpellSpellListEnabled[spellName].Remove(spellListName);
                            }

                            SpellsContext.SwitchSpellList(spellDefinition, spellListDefinition);
                        }

                        current++;
                    }
                }
            }
        }
    }
}
