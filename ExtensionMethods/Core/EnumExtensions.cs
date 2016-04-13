using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class EnumExtensions
    {
        /// <summary>
        /// 返回枚举的描述特性
        /// </summary>
        public static string GetCustomAttributeDescription(this Enum value)
        {
            var attr = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return attr.Description;
        }

        /// <summary>
        /// 转换成为枚举类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strEnum"></param>
        /// <returns></returns>
        public static T ToEnum<T>(this string strEnum)
        {
            return (T)Enum.Parse(typeof(T), strEnum);
        }

        /// <summary>
        /// 转换成为枚举类型
        /// </summary>
        /// <param name="strEnum"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Enum ToEnum(this string strEnum, Type type)
        {
            return (Enum)Enum.Parse(type, strEnum);
        }

    }
}
