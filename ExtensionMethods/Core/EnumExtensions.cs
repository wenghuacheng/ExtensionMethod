﻿using System;
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

    }
}
