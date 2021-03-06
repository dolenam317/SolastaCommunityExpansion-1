using System.CodeDom.Compiler;
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionAncestry)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class FeatureDefinitionAncestryExtensions
    {
        public static T SetDamageType<T>(this T entity, System.String value)
            where T : FeatureDefinitionAncestry
        {
            entity.SetField("damageType", value);
            return entity;
        }
    }
}