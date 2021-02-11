using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CsharpCoreRefactor
{
    public static class TypeEnumExtension
    {
        /// <summary>
        /// Item type enum
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetItemNameFromEnum(this ItemTypeEnum type)
        {
            try
            {
                var field = type.GetType().GetField(type.ToString());
                var customAttr = field.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (customAttr.Length > 0)
                    return (customAttr[0] as DescriptionAttribute).Description;

                return type.ToString();

            }
            catch (Exception)
            {
                throw;
            }        
        }

        /// <summary>
        /// Get Item type enum from name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static ItemTypeEnum GetTypeFromItemName(string name)
        {
            try
            {
                Type enumType = typeof(ItemTypeEnum);

                var enumValues = enumType.GetEnumValues();

                foreach (ItemTypeEnum value in enumValues)
                {
                    MemberInfo memberInfo =
                        enumType.GetMember(value.ToString()).First();

                    var descriptionAttribute =
                        memberInfo.GetCustomAttribute<DescriptionAttribute>();

                    if (descriptionAttribute != null && descriptionAttribute.Description.Equals(name))
                        return value;
                }

                return ItemTypeEnum.NotDefine;

            }
            catch (Exception) {
                throw;
            }        
        }
    }
}
