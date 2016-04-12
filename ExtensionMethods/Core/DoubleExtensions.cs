using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// 是否在区间内
        /// </summary>
        public static bool Between(this Double @this, Double minValue, Double maxValue)
        {
            return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
        }
        
        #region Double Method
        /// <summary>
        /// 指示指定数字是计算为负无穷大还是正无穷大
        /// </summary>
        public static Boolean IsInfinity(this Double d)
        {
            return Double.IsInfinity(d);
        }

        /// <summary>
        /// 指定数字的计算结果是否为不是数字
        /// </summary>
        public static Boolean IsNaN(this Double d)
        {
            return Double.IsNaN(d);
        }

        /// <summary>
        /// 数字是否计算为负无穷大
        /// </summary>
        public static Boolean IsNegativeInfinity(this Double d)
        {
            return Double.IsNegativeInfinity(d);
        }

        /// <summary>
        /// 数字是否计算为正无穷大
        /// </summary>
        public static Boolean IsPositiveInfinity(this Double d)
        {
            return Double.IsPositiveInfinity(d);
        }
        #endregion

        #region Math
        /// <summary>
        /// 获取绝对值
        /// </summary>
        public static Double Abs(this Double value)
        {
            return Math.Abs(value);
        }
              

        /// <summary>
        /// 返回大于此值的最小整数
        /// </summary>
        /// <param name="a">A double-precision floating-point number.</param>
        /// <returns>
        ///     The smallest integral value that is greater than or equal to . If  is equal to , , or , that value is
        ///     returned. Note that this method returns a  instead of an integral type.
        /// </returns>
        public static Double Ceiling(this Double a)
        {
            return Math.Ceiling(a);
        }
        
        /// <summary>
        /// e 的指定次幂
        /// </summary>
        public static Double Exp(this Double d)
        {
            return Math.Exp(d);
        }

        /// <summary>
        /// 返回小于此值的最大整数
        /// </summary>
        public static Double Floor(this Double d)
        {
            return Math.Floor(d);
        }

        /// <summary>
        /// 取余
        /// </summary>
        public static Double IEEERemainder(this Double x, Double y)
        {
            return Math.IEEERemainder(x, y);
        }

        /// <summary>
        /// 数字的自然对数（底为 e）
        /// </summary>
        public static Double Log(this Double d)
        {
            return Math.Log(d);
        }

        /// <summary>
        /// 数字的自然对数（底为 e）
        /// </summary>
        public static Double Log(this Double d, Double newBase)
        {
            return Math.Log(d, newBase);
        }

        /// <summary>
        /// 数字以 10 为底的对数
        /// </summary>
        public static Double Log10(this Double d)
        {
            return Math.Log10(d);
        }

        /// <summary>
        /// 取最大值
        /// </summary>
        public static Double Max(this Double val1, Double val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 取最小值
        /// </summary>
        public static Double Min(this Double val1, Double val2)
        {
            return Math.Min(val1, val2);
        }

        /// <summary>
        /// 指定次幂
        /// </summary>
        public static Double Pow(this Double x, Double y)
        {
            return Math.Pow(x, y);
        }

        /// <summary>
        /// 四舍五入
        /// </summary>
        public static Double Round(this Double a)
        {
            return Math.Round(a);
        }

        /// <summary>
        /// 按小数位四舍五入
        /// </summary>
        public static Double Round(this Double a, Int32 digits)
        {
            return Math.Round(a, digits);
        }

        /// <summary>
        /// 按舍入类型获取值
        /// </summary>
        public static Double Round(this Double a, MidpointRounding mode)
        {
            return Math.Round(a, mode);
        }

        /// <summary>
        /// 按舍入类型小数位获取值
        /// </summary>
        public static Double Round(this Double a, Int32 digits, MidpointRounding mode)
        {
            return Math.Round(a, digits, mode);
        }
        
        /// <summary>
        /// 平方根
        /// </summary>
        public static Double Sqrt(this Double d)
        {
            return Math.Sqrt(d);
        }

        /// <summary>
        /// 双精度浮点数的整数部分
        /// </summary>
        public static Double Truncate(this Double d)
        {
            return Math.Truncate(d);
        }
        #endregion

        #region TimeSpan
        /// <summary>
        /// 返回指定天数的时间间隔
        /// </summary>
        public static TimeSpan FromDays(this Double value)
        {
            return TimeSpan.FromDays(value);
        }

        /// <summary>
        /// 返回指定小时的时间间隔
        /// </summary>
        public static TimeSpan FromHours(this Double value)
        {
            return TimeSpan.FromHours(value);
        }

        /// <summary>
        /// 返回指定毫秒的时间间隔
        /// </summary>
        public static TimeSpan FromMilliseconds(this Double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        /// <summary>
        /// 返回指定分的时间间隔
        /// </summary>
        public static TimeSpan FromMinutes(this Double value)
        {
            return TimeSpan.FromMinutes(value);
        }

        /// <summary>
        /// 返回指定秒的时间间隔
        /// </summary>
        public static TimeSpan FromSeconds(this Double value)
        {
            return TimeSpan.FromSeconds(value);
        }
        #endregion
    }
}
