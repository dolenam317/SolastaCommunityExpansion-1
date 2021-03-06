using System.CodeDom.Compiler;
using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FoodDescription)), GeneratedCode("Community Expansion Extension Generator", "1.0.0")]
    public static partial class FoodDescriptionExtensions
    {
        public static FoodDescription Copy(this FoodDescription entity)
        {
            return new FoodDescription(entity);
        }

        public static T SetNutritiveCapacity<T>(this T entity, System.Int32 value)
            where T : FoodDescription
        {
            entity.SetField("nutritiveCapacity", value);
            return entity;
        }

        public static T SetPerishable<T>(this T entity, System.Boolean value)
            where T : FoodDescription
        {
            entity.SetField("perishable", value);
            return entity;
        }
    }
}