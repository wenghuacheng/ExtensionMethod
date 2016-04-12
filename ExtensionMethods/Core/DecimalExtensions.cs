using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// 转为金额两位小数
        /// </summary>
        public static Decimal ToMoney(this Decimal @this)
        {
            return Math.Round(@this, 2);
        }

        #region Math
        /// <summary>
        /// 返回绝对值
        /// </summary>
        public static Decimal Abs(this Decimal value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// 返回大于此值的最小整数
        /// </summary>
        public static Decimal Ceiling(this Decimal d)
        {
            return Math.Ceiling(d);
        }

        /// <summary>
        /// 返回小于此值的最大整数
        /// </summary>
        public static Decimal Floor(this Decimal d)
        {
            return Math.Floor(d);
        }

        /// <summary>
        /// 获取最大值
        /// </summary>
        public static Decimal Max(this Decimal val1, Decimal val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 获取最小值
        /// </summary>
        public static Decimal Min(this Decimal val1, Decimal val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        public static Decimal Round(this Decimal d)
        {
            return Math.Round(d);
        }

        /// <summary>
        /// 按小数位四舍五入
        /// </summary>
        public static Decimal Round(this Decimal d, Int32 decimals)
        {
            return Math.Round(d, decimals);
        }

        /// <summary>
        /// 按舍入类型获取值
        /// </summary>
        /// <param name="d">值</param>
        /// <param name="mode">舍入类型</param>
        public static Decimal Round(this Decimal d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        /// <summary>
        /// 按舍入类型小数位获取值
        /// </summary>
        /// <param name="d">值</param>
        /// <param name="decimals">小数位数</param>
        /// <param name="mode">舍入类型</param>
        public static Decimal Round(this Decimal d, Int32 decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }             

        /// <summary>
        /// 获取指定小数的整数部分
        /// </summary>
        public static Decimal Truncate(this Decimal d)
        {
            return Math.Truncate(d);
        }
        #endregion

        /// <summary>
        /// 值是否在区间内
        /// </summary>
        public static bool Between(this Decimal @this, Decimal minValue, Decimal maxValue)
        {
            return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
        }
        
        #region Decimal Method
        /// <summary>
        /// 两数相除
        /// </summary>
        public static Decimal Divide(this Decimal d1, Decimal d2)
        {
            return Decimal.Divide(d1, d2);
        }

        /// <summary>
        /// 转换为其等效的二进制表示形式,由四个元素组成的 32 位有符号整数数组
        /// </summary>
        public static Int32[] GetBits(this Decimal d)
        {
            return Decimal.GetBits(d);
        }

        /// <summary>
        /// 两数相乘
        /// </summary>
        public static Decimal Multiply(this Decimal d1, Decimal d2)
        {
            return Decimal.Multiply(d1, d2);
        }

        /// <summary>
        /// 取反(乘-1）
        /// </summary>
        public static Decimal Negate(this Decimal d)
        {
            return Decimal.Negate(d);
        }

        /// <summary>
        /// 取余
        /// </summary>
        public static Decimal Remainder(this Decimal d1, Decimal d2)
        {
            return Decimal.Remainder(d1, d2);
        }

        /// <summary>
        ///     Subtracts one specified  value from another.
        /// </summary>
        public static Decimal Subtract(this Decimal d1, Decimal d2)
        {
            return Decimal.Subtract(d1, d2);
        }

        /// <summary>
        /// 转换为等效的 8 位无符号整数
        /// </summary>
        public static Byte ToByte(this Decimal value)
        {
            return Decimal.ToByte(value);
        }

        /// <summary>
        /// 转为双精度浮点数
        /// </summary>
        public static Double ToDouble(this Decimal d)
        {
            return Decimal.ToDouble(d);
        }
        
        /// <summary>
        /// 转为整形
        /// </summary>
        public static Int32 ToInt32(this Decimal d)
        {
            return Decimal.ToInt32(d);
        }

        /// <summary>
        /// 转为长整形
        /// </summary>
        public static Int64 ToInt64(this Decimal d)
        {
            return Decimal.ToInt64(d);
        }

        /// <summary>
        /// 转为float
        /// </summary>
        public static Single ToSingle(this Decimal d)
        {
            return Decimal.ToSingle(d);
        }
        #endregion
    }
}
