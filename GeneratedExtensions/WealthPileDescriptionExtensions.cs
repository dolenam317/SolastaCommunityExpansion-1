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
    [TargetType(typeof(WealthPileDescription)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class WealthPileDescriptionExtensions
    {
        public static WealthPileDescription Copy(this WealthPileDescription entity)
        {
            return new WealthPileDescription(entity);
        }

        public static T SetBonuses<T>(this T entity, System.Int32[] value)
            where T : WealthPileDescription
        {
            entity.SetField("bonuses", value);
            return entity;
        }

        public static T SetDiceTypes<T>(this T entity, RuleDefinitions.DieType[] value)
            where T : WealthPileDescription
        {
            entity.SetField("diceTypes", value);
            return entity;
        }

        public static T SetWealth<T>(this T entity, System.Int32[] value)
            where T : WealthPileDescription
        {
            entity.SetField("wealth", value);
            return entity;
        }
    }
}