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
        ///     An object extension method that cast anonymous type to the specified type.
        /// </summary>
        /// <typeparam name="T">Generic type parameter. The specified type.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The object as the specified type.</returns>
        public static T As<T>(this object @this)
        {
            return (T)@this;
        }

        /// <summary>
        ///     An object extension method that converts the @this to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A T.</returns>
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
        ///     An object extension method that converts the @this to an or default.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>A T.</returns>
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
        ///     A T extension method that makes a deep copy of '@this' object.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>the copied object.</returns>
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
        ///     A T extension method that shallow copy.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A T.</returns>
        public static T ShallowCopy<T>(this T @this)
        {
            MethodInfo method = @this.GetType().GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);
            return (T)method.Invoke(@this, null);
        }

        /// <summary>
        ///     Returns an object of the specified type whose value is equivalent to the specified object.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <param name="typeCode">The type of object to return.</param>
        /// <returns>
        ///     An object whose underlying type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual
        ///     Basic), if  is null and  is , , or .
        /// </returns>
        public static Object ChangeType(this Object value, TypeCode typeCode)
        {
            return Convert.ChangeType(value, typeCode);
        }

        /// <summary>
        ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
        ///     supplies culture-specific formatting information.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <param name="typeCode">The type of object to return.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose underlying type is  and whose value is equivalent to .-or- A null reference (Nothing in
        ///     Visual Basic), if  is null and  is , , or .
        /// </returns>
        public static Object ChangeType(this Object value, TypeCode typeCode, IFormatProvider provider)
        {
            return Convert.ChangeType(value, typeCode, provider);
        }

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to the specified object.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <param name="conversionType">The type of object to return.</param>
        /// <returns>
        ///     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
        ///     is null and  is not a value type.
        /// </returns>
        public static Object ChangeType(this Object value, Type conversionType)
        {
            return Convert.ChangeType(value, conversionType);
        }

        /// <summary>
        ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
        ///     supplies culture-specific formatting information.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <param name="conversionType">The type of object to return.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
        ///     reference (Nothing in Visual Basic), if  is null and  is not a value type.
        /// </returns>
        public static Object ChangeType(this Object value, Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(value, conversionType, provider);
        }

        /// <summary>
        ///     Returns an object of the specified type and whose value is equivalent to the specified object.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">An object that implements the  interface.</param>
        /// <returns>
        ///     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
        ///     is null and  is not a value type.
        /// </returns>
        public static Object ChangeType<T>(this Object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        ///     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
        ///     supplies culture-specific formatting information.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">An object that implements the  interface.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        ///     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
        ///     reference (Nothing in Visual Basic), if  is null and  is not a value type.
        /// </returns>
        public static Object ChangeType<T>(this Object value, IFormatProvider provider)
        {
            return (T)Convert.ChangeType(value, typeof(T), provider);
        }

        /// <summary>
        ///     Returns the  for the specified object.
        /// </summary>
        /// <param name="value">An object that implements the  interface.</param>
        /// <returns>The  for , or  if  is null.</returns>
        public static TypeCode GetTypeCode(this Object value)
        {
            return Convert.GetTypeCode(value);
        }

        /// <summary>
        ///     Determines whether the specified  instances are the same instance.
        /// </summary>
        /// <param name="objA">The first object to compare.</param>
        /// <param name="objB">The second object  to compare.</param>
        /// <returns>true if  is the same instance as  or if both are null; otherwise, false.</returns>
        public static Boolean ReferenceEquals(this Object objA, Object objB)
        {
            return Object.ReferenceEquals(objA, objB);
        }

        /// <summary>
        ///     A T extension method that query if '@this' is null.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if null, false if not.</returns>
        public static bool IsNull<T>(this T @this) where T : class
        {
            return @this == null;
        }

        /// <summary>
        ///     A T extension method that query if '@this' is not null.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if not null, false if not.</returns>
        public static bool IsNotNull<T>(this T @this) where T : class
        {
            return @this != null;
        }

        #region 类型判断
        /// <summary>
        ///     An object extension method that query if '@this' is valid bool.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid bool, false if not.</returns>
        public static bool IsValidBoolean(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            bool result;
            return bool.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid byte.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid byte, false if not.</returns>
        public static bool IsValidByte(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            byte result;
            return byte.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid char.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid char, false if not.</returns>
        public static bool IsValidChar(this object @this)
        {
            char result;
            return char.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid System.DateTime.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid System.DateTime, false if not.</returns>
        public static bool IsValidDateTime(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            DateTime result;
            return DateTime.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid System.DateTimeOffset.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid System.DateTimeOffset, false if not.</returns>
        public static bool IsValidDateTimeOffSet(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            DateTimeOffset result;
            return DateTimeOffset.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid decimal.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid decimal, false if not.</returns>
        public static bool IsValidDecimal(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            decimal result;
            return decimal.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid double.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid double, false if not.</returns>
        public static bool IsValidDouble(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            double result;
            return double.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid float.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid float, false if not.</returns>
        public static bool IsValidFloat(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            float result;
            return float.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid System.Guid.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid System.Guid, false if not.</returns>
        public static bool IsValidGuid(this object @this)
        {
            Guid result;
            return Guid.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid short, false if not.</returns>
        public static bool IsValidInt16(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            short result;
            return short.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid int.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid int, false if not.</returns>
        public static bool IsValidInt32(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            int result;
            return int.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid long, false if not.</returns>
        public static bool IsValidInt64(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            long result;
            return long.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid long.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid long, false if not.</returns>
        public static bool IsValidLong(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            long result;
            return long.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid sbyte.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid sbyte, false if not.</returns>
        public static bool IsValidSByte(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            sbyte result;
            return sbyte.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid short.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid short, false if not.</returns>
        public static bool IsValidShort(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            short result;
            return short.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid float.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid float, false if not.</returns>
        public static bool IsValidSingle(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            float result;
            return float.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid string.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid string, false if not.</returns>
        public static bool IsValidString(this object @this)
        {
            return true;
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid ushort.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ushort, false if not.</returns>
        public static bool IsValidUInt16(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ushort result;
            return ushort.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid uint.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid uint, false if not.</returns>
        public static bool IsValidUInt32(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            uint result;
            return uint.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid ulong.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ulong, false if not.</returns>
        public static bool IsValidUInt64(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ulong result;
            return ulong.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid ulong.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ulong, false if not.</returns>
        public static bool IsValidULong(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ulong result;
            return ulong.TryParse(@this.ToString(), out result);
        }

        /// <summary>
        ///     An object extension method that query if '@this' is valid ushort.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if valid ushort, false if not.</returns>
        public static bool IsValidUShort(this object @this)
        {
            if (@this == null)
            {
                return true;
            }

            ushort result;
            return ushort.TryParse(@this.ToString(), out result);
        }

        #endregion
    }
}
