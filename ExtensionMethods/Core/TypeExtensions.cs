using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class TypeExtensions
    {
        #region CreateInstance
        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
        {
            return (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture);
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
        {
            return (T)Activator.CreateInstance(@this, bindingAttr, binder, args, culture, activationAttributes);
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this, Object[] args)
        {
            return (T)Activator.CreateInstance(@this, args);
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this, Object[] args, Object[] activationAttributes)
        {
            return (T)Activator.CreateInstance(@this, args, activationAttributes);
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this)
        {
            return (T)Activator.CreateInstance(@this);
        }

        /// <summary>
        /// 创建实例
        /// </summary>
        public static T CreateInstance<T>(this Type @this, Boolean nonPublic)
        {
            return (T)Activator.CreateInstance(@this, nonPublic);
        }
        #endregion
    }
}
