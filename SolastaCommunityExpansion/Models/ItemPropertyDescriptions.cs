﻿using SolastaCommunityExpansion.Builders;
using static EquipmentDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionAttackModifiers;

namespace SolastaCommunityExpansion.Models;

public static class ItemPropertyDescriptions
{
    public static readonly ItemPropertyDescription WeaponPlus1 = BuildFrom(AttackModifierWeaponPlus1);

    public static readonly ItemPropertyDescription WeaponPlus2 = BuildFrom(AttackModifierWeaponPlus2);

    public static readonly ItemPropertyDescription WeaponPlus3 = BuildFrom(AttackModifierWeaponPlus3);

    public static ItemPropertyDescription BuildFrom(
        FeatureDefinition feature,
        bool appliesOnItemOnly = true,
        KnowledgeAffinity knowledgeAffinity = KnowledgeAffinity.ActiveAndHidden)
    {
        return ItemPropertyDescriptionBuilder.From(feature, appliesOnItemOnly, knowledgeAffinity).Build();
    }

    public static ItemPropertyDescription BuildFrom(
        ConditionDefinition conditione,
        bool appliesOnItemOnly = true,
        KnowledgeAffinity knowledgeAffinity = KnowledgeAffinity.ActiveAndHidden)
    {
        return ItemPropertyDescriptionBuilder.From(conditione, appliesOnItemOnly, knowledgeAffinity).Build();
    }
}