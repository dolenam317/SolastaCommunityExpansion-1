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
    [TargetType(typeof(FeatureDefinitionProficiency)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class FeatureDefinitionProficiencyExtensions
    {
        public static T AddForbiddenItemTags<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionProficiency
        {
            AddForbiddenItemTags(entity, value.AsEnumerable());
            return entity;
        }

        public static T AddForbiddenItemTags<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionProficiency
        {
            entity.ForbiddenItemTags.AddRange(value);
            return entity;
        }

        public static T AddProficiencies<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionProficiency
        {
            AddProficiencies(entity, value.AsEnumerable());
            return entity;
        }

        public static T AddProficiencies<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionProficiency
        {
            entity.Proficiencies.AddRange(value);
            return entity;
        }

        public static T ClearForbiddenItemTags<T>(this T entity)
            where T : FeatureDefinitionProficiency
        {
            entity.ForbiddenItemTags.Clear();
            return entity;
        }

        public static T ClearProficiencies<T>(this T entity)
            where T : FeatureDefinitionProficiency
        {
            entity.Proficiencies.Clear();
            return entity;
        }

        public static T SetForbiddenItemTags<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionProficiency
        {
            SetForbiddenItemTags(entity, value.AsEnumerable());
            return entity;
        }

        public static T SetForbiddenItemTags<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionProficiency
        {
            entity.ForbiddenItemTags.SetRange(value);
            return entity;
        }

        public static T SetProficiencies<T>(this T entity,  params  System . String [ ]  value)
            where T : FeatureDefinitionProficiency
        {
            SetProficiencies(entity, value.AsEnumerable());
            return entity;
        }

        public static T SetProficiencies<T>(this T entity, IEnumerable<System.String> value)
            where T : FeatureDefinitionProficiency
        {
            entity.Proficiencies.SetRange(value);
            return entity;
        }

        public static T SetProficienciesFormat<T>(this T entity, System.Text.StringBuilder value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficienciesFormat", value);
            return entity;
        }

        public static T SetProficiencyType<T>(this T entity, RuleDefinitions.ProficiencyType value)
            where T : FeatureDefinitionProficiency
        {
            entity.SetField("proficiencyType", value);
            return entity;
        }
    }
}