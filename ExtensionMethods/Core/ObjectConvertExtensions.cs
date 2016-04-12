using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class ObjectConvertExtensions
    {
        /// <summary>
        /// 转为bool类型
        /// </summary>
        public static bool ToBooleanOrDefault(this object @this)
        {
            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return default(bool);
            }
        }

        /// <summary>
        /// 转为bool类型并提供默认类型
        /// </summary>
        public static bool ToBooleanOrDefault(this object @this, bool defaultValue)
        {
            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
        
        /// <summary>
        /// 转为字节
        /// </summary>
        public static byte ToByteOrDefault(this object @this)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return default(byte);
            }
        }

        /// <summary>
        /// 转为字节,并提供失败的默认值
        /// </summary>
        public static byte ToByteOrDefault(this object @this, byte defaultValue)
        {
            try
            {
                return Convert.ToByte(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }        

        /// <summary>
        /// 转为字符
        /// </summary>
        public static char ToCharOrDefault(this object @this)
        {
            try
            {
                return Convert.ToChar(@this);
            }
            catch (Exception)
            {
                return default(char);
            }
        }

        /// <summary>
        /// 转为字符,并提供失败的默认值
        /// </summary>
        public static char ToCharOrDefault(this object @this, char defaultValue)
        {
            try
            {
                return Convert.ToChar(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        /// 转为DateTime
        /// </summary>
        public static DateTime ToDateTimeOrDefault(this object @this)
        {
            try
            {
                return Convert.ToDateTime(@this);
            }
            catch (Exception)
            {
                return default(DateTime);
            }
        }

        /// <summary>
        /// 转为DateTime,并提供失败的默认值
        /// </summary>
        public static DateTime ToDateTimeOrDefault(this object @this, DateTime defaultValue)
        {
            try
            {
                return Convert.ToDateTime(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
     
        /// <summary>
        /// 转为decimal
        /// </summary>
        public static decimal ToDecimalOrDefault(this object @this)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return default(decimal);
            }
        }

        /// <summary>
        /// 转为decimal,并提供失败的默认值
        /// </summary>
        public static decimal ToDecimalOrDefault(this object @this, decimal defaultValue)
        {
            try
            {
                return Convert.ToDecimal(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为double
        /// </summary>
        public static double ToDoubleOrDefault(this object @this)
        {
            try
            {
                return Convert.ToDouble(@this);
            }
            catch (Exception)
            {
                return default(double);
            }
        }

        /// <summary>
        /// 转为double,并提供失败的默认值
        /// </summary>
        public static double ToDoubleOrDefault(this object @this, double defaultValue)
        {
            try
            {
                return Convert.ToDouble(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        /// 转为float
        /// </summary>
        public static float ToFloatOrDefault(this object @this)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return default(float);
            }
        }

        /// <summary>
        /// 转为float,并提供失败的默认值
        /// </summary>
        public static float ToFloatOrDefault(this object @this, float defaultValue)
        {
            try
            {
                return Convert.ToSingle(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }        
      
        /// <summary>
        /// 生成Guid
        /// </summary>
        public static Guid ToGuidOrDefault(this object @this)
        {
            try
            {
                return new Guid(@this.ToString());
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// 生成Guid,并提供失败的默认值
        /// </summary>
        public static Guid ToGuidOrDefault(this object @this, Guid defaultValue)
        {
            try
            {
                return new Guid(@this.ToString());
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
        
        /// <summary>
        /// 转为int
        /// </summary>
        public static int ToInt32OrDefault(this object @this)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return default(int);
            }
        }

        /// <summary>
        /// 转为int,并提供失败的默认值
        /// </summary>
        public static int ToInt32OrDefault(this object @this, int defaultValue)
        {
            try
            {
                return Convert.ToInt32(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
        
        /// <summary>
        /// 转为long
        /// </summary>
        public static long ToInt64OrDefault(this object @this)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return default(long);
            }
        }

        /// <summary>
        /// 转为long,并提供失败的默认值
        /// </summary>
        public static long ToInt64OrDefault(this object @this, long defaultValue)
        {
            try
            {
                return Convert.ToInt64(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        /// 转为bool?
        /// </summary>
        public static bool? ToNullableBooleanOrDefault(this object @this)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return default(bool);
            }
        }

        /// <summary>
        ///  转为bool?,并提供失败的默认值
        /// </summary>
        public static bool? ToNullableBooleanOrDefault(this object @this, bool? defaultValue)
        {
            try
            {
                if (@this == null || @this == DBNull.Value)
                {
                    return null;
                }

                return Convert.ToBoolean(@this);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
