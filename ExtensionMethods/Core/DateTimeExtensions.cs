using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
     public static class DateTimeExtensions
    { 
        /// <summary>
        /// 获取年龄
        /// </summary>
        /// <param name="this">出生时间</param>
        /// <returns>年龄</returns>
        public static int Age(this DateTime @this)
        {
            if (DateTime.Today.Month < @this.Month ||
                DateTime.Today.Month == @this.Month &&
                DateTime.Today.Day < @this.Day)
            {
                return DateTime.Today.Year - @this.Year - 1;
            }
            return DateTime.Today.Year - @this.Year;
        }

        /// <summary>
        /// 与今天的时间间隔
        /// </summary>
        /// <param name="datetime">先前的时间</param>
        /// <returns>时间间隔</returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }

        #region GetTime
        /// <summary>
        /// 返回当天的最后时刻即"23:59:59:999"格式时间
        /// </summary>
        public static DateTime EndOfDay(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        /// <summary>
        /// 返回当月的最后时刻即"23:59:59:999"格式时间
        /// </summary>
        public static DateTime EndOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1).AddMonths(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        /// <summary>
        /// 返回本周的最后时刻即"23:59:59:999"格式时间
        /// </summary>
        /// <param name="dt">判断的时间</param>
        /// <param name="startDayOfWeek">起始的星期</param>
        public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            DateTime end = dt;
            DayOfWeek endDayOfWeek = startDayOfWeek - 1;
            if (endDayOfWeek < 0)
            {
                endDayOfWeek = DayOfWeek.Saturday;
            }

            if (end.DayOfWeek != endDayOfWeek)
            {
                if (endDayOfWeek < end.DayOfWeek)
                {
                    end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
                }
                else
                {
                    end = end.AddDays(endDayOfWeek - end.DayOfWeek);
                }
            }

            return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
        }

        /// <summary>
        /// 返回当年的最后时刻即"23:59:59:999"格式时间
        /// </summary>
        public static DateTime EndOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1).AddYears(1).Subtract(new TimeSpan(0, 0, 0, 0, 1));
        }

        /// <summary>
        /// 返回本周第一天
        /// </summary>
        public static DateTime FirstDayOfWeek(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(-(int)@this.DayOfWeek);
        }

        /// <summary>
        /// 返回本周最后一天
        /// </summary>
        public static DateTime LastDayOfWeek(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day).AddDays(6 - (int)@this.DayOfWeek);
        }

        /// <summary>
        /// 返回当天的起始即"00:00:00:000"格式时间
        /// </summary>
        public static DateTime StartOfDay(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, @this.Day);
        }

        /// <summary>
        /// 返回当月的起始即"00:00:00:000"格式时间
        /// </summary>
        public static DateTime StartOfMonth(this DateTime @this)
        {
            return new DateTime(@this.Year, @this.Month, 1);
        }

        /// <summary>
        /// 返回本周的起始即"00:00:00:000"格式时间
        /// </summary>
        /// <param name="dt">判断的时间</param>
        /// <param name="startDayOfWeek">起始的星期</param>
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            var start = new DateTime(dt.Year, dt.Month, dt.Day);

            if (start.DayOfWeek != startDayOfWeek)
            {
                int d = startDayOfWeek - start.DayOfWeek;
                if (startDayOfWeek <= start.DayOfWeek)
                {
                    return start.AddDays(d);
                }
                return start.AddDays(-7 + d);
            }

            return start;
        }

        /// <summary>
        /// 返回当年的起始即"00:00:00:000"格式时间
        /// </summary>
        public static DateTime StartOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1);
        }
         
        /// <summary>
        /// 返回明天
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>Tomorrow date at same time.</returns>
        public static DateTime Tomorrow(this DateTime @this)
        {
            return @this.AddDays(1);
        }

        /// <summary>
        /// 返回昨天
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>Yesterday date at same time.</returns>
        public static DateTime Yesterday(this DateTime @this)
        {
            return @this.AddDays(-1);
        }
        #endregion

        #region SetTime
        /// <summary>
        /// 在当前日期的基础上设置小时
        /// </summary>
        public static DateTime SetTime(this DateTime current, int hour)
        {
            return SetTime(current, hour, 0, 0, 0);
        }

        /// <summary>
        /// 在当前日期的基础上设置时,分
        /// </summary>
        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            return SetTime(current, hour, minute, 0, 0);
        }

        /// <summary>
        /// 在当前日期的基础上设置时,分,秒
        /// </summary>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            return SetTime(current, hour, minute, second, 0);
        }

        /// <summary>
        /// 设置时间
        /// </summary>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
        }
        #endregion

        #region 日期类型判断
        /// <summary>
        /// 是否是下午
        /// </summary>
        public static bool IsAfternoon(this DateTime @this)
        {
            return @this.TimeOfDay >= new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
        }

        /// <summary>
        /// 时间是否相同
        /// </summary>
        public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
        {
            return (date.Date == dateToCompare.Date);
        }
         
        /// <summary>
        /// 是否是早上
        /// </summary>
        public static bool IsMorning(this DateTime @this)
        {
            return @this.TimeOfDay < new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
        }        
       

        /// <summary>
        /// 是否是今天
        /// </summary>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }

        /// <summary>
        /// 是否是工作日
        /// </summary>
        public static bool IsWeekDay(this DateTime @this)
        {
            return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }

        /// <summary>
        /// 是否是周末
        /// </summary>
        public static bool IsWeekendDay(this DateTime @this)
        {
            return (@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }
        #endregion

        /// <summary>
        /// 判断时间是否在某个时间段内
        /// </summary>
        public static bool Between(this DateTime @this, DateTime minValue, DateTime maxValue)
        {
            return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
        }

        /// <summary>
        /// 判断时间是否在某个时间段内
        /// </summary>
        public static bool InRange(this DateTime @this, DateTime minValue, DateTime maxValue)
        {
            return @this.CompareTo(minValue) >= 0 && @this.CompareTo(maxValue) <= 0;
        }
    }
}
