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
    [TargetType(typeof(SaveAffinityBySenseDescription)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class SaveAffinityBySenseDescriptionExtensions
    {
        public static SaveAffinityBySenseDescription Copy(this SaveAffinityBySenseDescription entity)
        {
            var copy = new SaveAffinityBySenseDescription();
            copy.Copy(entity);
            return copy;
        }

        public static T SetAdvantageType<T>(this T entity, RuleDefinitions.AdvantageType value)
            where T : SaveAffinityBySenseDescription
        {
            entity.SetField("advantageType", value);
            return entity;
        }

        public static T SetSenseType<T>(this T entity, SenseMode.Type value)
            where T : SaveAffinityBySenseDescription
        {
            entity.SetField("senseType", value);
            return entity;
        }
    }
}