using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class Int32Extensions
    {
        #region 类型判断
        /// <summary>
        /// 是否是偶数
        /// </summary>
        public static bool IsEven(this Int32 @this)
        {
            return @this % 2 == 0;
        }

        /// <summary>
        /// 是否是factor的倍数
        /// </summary>
        public static bool IsMultipleOf(this Int32 @this, Int32 factor)
        {
            return @this % factor == 0;
        }

        /// <summary>
        /// 是否是奇数
        /// </summary>
        public static bool IsOdd(this Int32 @this)
        {
            return @this % 2 != 0;
        }

        /// <summary>
        /// 是否是素数
        /// </summary>
        public static bool IsPrime(this Int32 @this)
        {
            if (@this == 1 || @this == 2)
            {
                return true;
            }

            if (@this % 2 == 0)
            {
                return false;
            }

            var sqrt = (Int32)Math.Sqrt(@this);
            for (Int64 t = 3; t <= sqrt; t = t + 2)
            {
                if (@this % t == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 是否是闰年
        /// </summary>
        /// <param name="year">A 4-digit year.</param>
        /// <returns>true if  is a leap year; otherwise, false.</returns>
        public static Boolean IsLeapYear(this Int32 year)
        {
            return DateTime.IsLeapYear(year);
        }
        #endregion

        #region TiemSpan
        /// <summary>
        /// 获取天为单位时间间隔
        /// </summary>
        public static TimeSpan Days(this Int32 @this)
        {
            return TimeSpan.FromDays(@this);
        }

        /// <summary>
        /// 获取小时为单位时间间隔
        /// </summary>
        public static TimeSpan Hours(this Int32 @this)
        {
            return TimeSpan.FromHours(@this);
        }

        /// <summary>
        /// 获取毫秒为单位时间间隔
        /// </summary>
        public static TimeSpan Milliseconds(this Int32 @this)
        {
            return TimeSpan.FromMilliseconds(@this);
        }

        /// <summary>
        /// 获取分为单位时间间隔
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Minutes(this Int32 @this)
        {
            return TimeSpan.FromMinutes(@this);
        }

        /// <summary>
        /// 获取秒为单位时间间隔
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Seconds(this Int32 @this)
        {
            return TimeSpan.FromSeconds(@this);
        }

        /// <summary>
        /// 获取周为单位时间间隔
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Weeks(this Int32 @this)
        {
            return TimeSpan.FromDays(@this * 7);
        }
        #endregion

        /// </summary>
        /// 指定年月中的天数
        /// </summary>
        public static Int32 DaysInMonth(this Int32 year, Int32 month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        #region Math
        /// <summary>
        /// 绝对值
        /// </summary>
        public static Int32 Abs(this Int32 value)
        {
            return Math.Abs(value);
        }

        /// <summary>
        /// 两个 32 位数字的完整乘积
        /// </summary>
        public static Int64 BigMul(this Int32 a, Int32 b)
        {
            return Math.BigMul(a, b);
        }

        /// <summary>
        /// 计算两个 32 位有符号整数的商，并通过输出参数返回余数
        /// </summary>
        /// <param name="a">被除数</param>
        /// <param name="b">除数</param>
        /// <param name="result">余数</param>
        /// <returns>指定数字的商</returns>
        public static Int32 DivRem(this Int32 a, Int32 b, out Int32 result)
        {
            return Math.DivRem(a, b, out result);
        }

        /// <summary>
        /// 最大值
        /// </summary>
        public static Int32 Max(this Int32 val1, Int32 val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 最小值
        /// </summary>
        public static Int32 Min(this Int32 val1, Int32 val2)
        {
            return Math.Min(val1, val2);
        }

        #endregion

        /// <summary>
        /// 将整数值由主机字节顺序转换为网络字节顺序
        /// </summary>
        public static Int32 HostToNetworkOrder(this Int32 host)
        {
            return IPAddress.HostToNetworkOrder(host);
        }

        /// <summary>
        /// 将整数值由网络字节顺序转换为主机字节顺序
        /// </summary>
        public static Int32 NetworkToHostOrder(this Int32 network)
        {
            return IPAddress.NetworkToHostOrder(network);
        }
    }
}
