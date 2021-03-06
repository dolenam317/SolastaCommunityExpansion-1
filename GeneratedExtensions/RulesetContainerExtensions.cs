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
    [TargetType(typeof(RulesetContainer)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class RulesetContainerExtensions
    {
        public static T AddInventorySlots<T>(this T entity,  params  RulesetInventorySlot [ ]  value)
            where T : RulesetContainer
        {
            AddInventorySlots(entity, value.AsEnumerable());
            return entity;
        }

        public static T AddInventorySlots<T>(this T entity, IEnumerable<RulesetInventorySlot> value)
            where T : RulesetContainer
        {
            entity.InventorySlots.AddRange(value);
            return entity;
        }

        public static T ClearInventorySlots<T>(this T entity)
            where T : RulesetContainer
        {
            entity.InventorySlots.Clear();
            return entity;
        }

        public static System.Collections.Generic.List<RulesetItem> GetEmptyStacks<T>(this T entity)
            where T : RulesetContainer
        {
            return entity.GetField<System.Collections.Generic.List<RulesetItem>>("emptyStacks");
        }

        public static System.Collections.Generic.List<RulesetItem> GetItemsToReorder<T>(this T entity)
            where T : RulesetContainer
        {
            return entity.GetField<System.Collections.Generic.List<RulesetItem>>("itemsToReorder");
        }

        public static T SetContainerContentModified<T>(this T entity, RulesetContainer.ContainerContentModifiedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("<ContainerContentModified>k__BackingField", value);
            return entity;
        }

        public static T SetHasBeenOpenedOnce<T>(this T entity, System.Boolean value)
            where T : RulesetContainer
        {
            entity.HasBeenOpenedOnce = value;
            return entity;
        }

        public static T SetInventorySlots<T>(this T entity,  params  RulesetInventorySlot [ ]  value)
            where T : RulesetContainer
        {
            SetInventorySlots(entity, value.AsEnumerable());
            return entity;
        }

        public static T SetInventorySlots<T>(this T entity, IEnumerable<RulesetInventorySlot> value)
            where T : RulesetContainer
        {
            entity.InventorySlots.SetRange(value);
            return entity;
        }

        public static T SetIsRegisteringItem<T>(this T entity, System.Boolean value)
            where T : RulesetContainer
        {
            entity.SetField("isRegisteringItem", value);
            return entity;
        }

        public static T SetMinSlotsNumber<T>(this T entity, System.Int32 value)
            where T : RulesetContainer
        {
            entity.SetField("minSlotsNumber", value);
            return entity;
        }

        public static T SetName<T>(this T entity, System.String value)
            where T : RulesetContainer
        {
            entity.Name = value;
            return entity;
        }

        public static T SetOnItemEquiped<T>(this T entity, RulesetInventorySlot.ItemEquipedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemEquiped", value);
            return entity;
        }

        public static T SetOnItemReleased<T>(this T entity, RulesetInventorySlot.ItemReleasedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemReleased", value);
            return entity;
        }

        public static T SetOnItemStacksChanged<T>(this T entity, RulesetInventorySlot.ItemStacksChangedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemStacksChanged", value);
            return entity;
        }

        public static T SetOnItemUnequiped<T>(this T entity, RulesetInventorySlot.ItemUnequipedHandler value)
            where T : RulesetContainer
        {
            entity.SetField("onItemUnequiped", value);
            return entity;
        }
    }
}