using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class ObjectExtensions
    {
        #region Cast
        /// <summary>
        /// 类型转换
        /// </summary>
        public static T AsOrDefault<T>(this object @this)
        {
            try
            {
                return (T)@this;
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 类型转换,并提供失败默认值
        /// </summary>
        public static T AsOrDefault<T>(this object @this, T defaultValue)
        {
            try
            {
                return (T)@this;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
        #endregion

        /// <summary>
        /// 深拷贝
        /// </summary>
        public static T DeepClone<T>(this T @this)
        {
            IFormatter formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, @this);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
        
        /// <summary>
        /// 是否是相同实例
        /// </summary>
        public static Boolean ReferenceEquals(this Object objA, Object objB)
        {
            return Object.ReferenceEquals(objA, objB);
        }

        /// <summary>
        /// 是否是空
        /// </summary>
        public static bool IsNull<T>(this T @this) where T : class
        {
            return @this == null;
        }

        /// <summary>
        /// 是否非空
        /// </summary>
        public static bool IsNotNull<T>(this T @this) where T : class
        {
            return @this != null;
        }

        #region 类型判断
        /// <summary>
        /// 是否是bool类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidBoolean(this object @this)
        {
            bool result;
            return bool.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是字节类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidByte(this object @this)
        {
            byte result;
            return byte.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是字符类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidChar(this object @this)
        {
            char result;
            return char.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是DateTime类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidDateTime(this object @this)
        {
            DateTime result;
            return DateTime.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是decimal类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidDecimal(this object @this)
        {
            decimal result;
            return decimal.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是double类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidDouble(this object @this)
        {
            double result;
            return double.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是float类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidFloat(this object @this)
        {
            float result;
            return float.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是Guid类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidGuid(this object @this)
        {
            Guid result;
            return Guid.TryParse(@this.ToString(), out result);
        }
                
        /// <summary>
        /// 是否是int类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidInt32(this object @this)
        {
            int result;
            return int.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        /// 是否是long类型(空值调用此方法会异常)
        /// </summary>
        public static bool IsValidInt64(this object @this)
        {
            long result;
            return long.TryParse(@this.ToString(), out result);
        }
        #endregion
    }
}
