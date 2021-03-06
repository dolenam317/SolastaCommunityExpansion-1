using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using TA.AI;
using TA;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using  static  ActionDefinitions ;
using  static  TA . AI . DecisionPackageDefinition ;
using  static  TA . AI . DecisionDefinition ;
using  static  RuleDefinitions ;
using  static  BanterDefinitions ;
using  static  Gui ;
using  static  GadgetDefinitions ;
using  static  BestiaryDefinitions ;
using  static  CursorDefinitions ;
using  static  AnimationDefinitions ;
using  static  FeatureDefinitionAutoPreparedSpells ;
using  static  FeatureDefinitionCraftingAffinity ;
using  static  CharacterClassDefinition ;
using  static  CreditsGroupDefinition ;
using  static  SoundbanksDefinition ;
using  static  CampaignDefinition ;
using  static  GraphicsCharacterDefinitions ;
using  static  GameCampaignDefinitions ;
using  static  FeatureDefinitionAbilityCheckAffinity ;
using  static  TooltipDefinitions ;
using  static  BaseBlueprint ;
using  static  MorphotypeElementDefinition ;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionRegeneration)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class FeatureDefinitionRegenerationExtensions
    {
        public static T AddPreventingDamages<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionRegeneration
        {
            AddPreventingDamages(entity, value.AsEnumerable());
            return entity;
        }

        public static T AddPreventingDamages<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionRegeneration
        {
            entity.PreventingDamages.AddRange(value);
            return entity;
        }

        public static T ClearPreventingDamages<T>(this T entity)
            where T : FeatureDefinitionRegeneration
        {
            entity.PreventingDamages.Clear();
            return entity;
        }

        public static T SetBonus<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("bonus", value);
            return entity;
        }

        public static T SetDiceNumber<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("diceNumber", value);
            return entity;
        }

        public static T SetDieType<T>(this T entity, RuleDefinitions.DieType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("dieType", value);
            return entity;
        }

        public static T SetParticlePrefab<T>(this T entity, UnityEngine.AddressableAssets.AssetReference value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("particlePrefab", value);
            return entity;
        }

        public static T SetPreventingDamages<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionRegeneration
        {
            SetPreventingDamages(entity, value.AsEnumerable());
            return entity;
        }

        public static T SetPreventingDamages<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionRegeneration
        {
            entity.PreventingDamages.SetRange(value);
            return entity;
        }

        public static T SetTickNumber<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickNumber", value);
            return entity;
        }

        public static T SetTickType<T>(this T entity, RuleDefinitions.DurationType value)
            where T : FeatureDefinitionRegeneration
        {
            entity.SetField("tickType", value);
            return entity;
        }
    }
}