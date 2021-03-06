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
    [TargetType(typeof(CreditsTableDefinition)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class CreditsTableDefinitionExtensions
    {
        public static T AddCreditGroups<T>(this T entity,  params  CreditsGroupDefinition [ ]  value)
            where T : CreditsTableDefinition
        {
            AddCreditGroups(entity, value.AsEnumerable());
            return entity;
        }

        public static T AddCreditGroups<T>(this T entity, IEnumerable<CreditsGroupDefinition> value)
            where T : CreditsTableDefinition
        {
            entity.CreditGroups.AddRange(value);
            return entity;
        }

        public static T ClearCreditGroups<T>(this T entity)
            where T : CreditsTableDefinition
        {
            entity.CreditGroups.Clear();
            return entity;
        }

        public static System.Collections.Generic.List<CreditsStyleDuplet> GetStyleDuplets<T>(this T entity)
            where T : CreditsTableDefinition
        {
            return entity.GetField<System.Collections.Generic.List<CreditsStyleDuplet>>("styleDuplets");
        }

        public static T SetBackersTextAsset<T>(this T entity, UnityEngine.TextAsset value)
            where T : CreditsTableDefinition
        {
            entity.SetField("backersTextAsset", value);
            return entity;
        }

        public static T SetCreditGroups<T>(this T entity,  params  CreditsGroupDefinition [ ]  value)
            where T : CreditsTableDefinition
        {
            SetCreditGroups(entity, value.AsEnumerable());
            return entity;
        }

        public static T SetCreditGroups<T>(this T entity, IEnumerable<CreditsGroupDefinition> value)
            where T : CreditsTableDefinition
        {
            entity.CreditGroups.SetRange(value);
            return entity;
        }

        public static T SetDescriptionLineHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("descriptionLineHeight", value);
            return entity;
        }

        public static T SetDescriptionWordSpacing<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("descriptionWordSpacing", value);
            return entity;
        }

        public static T SetJobTitleLineHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("jobTitleLineHeight", value);
            return entity;
        }

        public static T SetLargeSpacingHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("largeSpacingHeight", value);
            return entity;
        }

        public static T SetNameLineHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("nameLineHeight", value);
            return entity;
        }

        public static T SetSectionLineHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("sectionLineHeight", value);
            return entity;
        }

        public static T SetSmallSpacingHeight<T>(this T entity, System.Single value)
            where T : CreditsTableDefinition
        {
            entity.SetField("smallSpacingHeight", value);
            return entity;
        }
    }
}