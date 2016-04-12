using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class DateTimeFormatExtensions
    {
        #region F 2005年11月5日 14:23:23
        /// <summary>
        /// 2005年11月5日 14:23:23
        /// </summary>
        public static string ToFullDateTimeString(this DateTime @this)
        {
            return @this.ToString("F", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005年11月5日 14:23:23
        /// </summary>
        public static string ToFullDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("F", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005年11月5日 14:23:23
        /// </summary>
        public static string ToFullDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("F", culture);
        }
        #endregion

        #region f 2005年11月5日 14:23
        /// <summary>
        /// 2005年11月5日 14:23
        /// </summary>
        public static string ToLongDateShortTimeString(this DateTime @this)
        {
            return @this.ToString("f", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005年11月5日 14:23
        /// </summary>
        public static string ToLongDateShortTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("f", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005年11月5日 14:23
        /// </summary>
        public static string ToLongDateShortTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("f", culture);
        }
        #endregion

        #region D 2005年11月5日
        /// <summary>
        ///  2005年11月5日
        /// </summary>
        public static string ToLongDateString(this DateTime @this)
        {
            return @this.ToString("D", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        ///  2005年11月5日
        /// </summary>
        public static string ToLongDateString(this DateTime @this, string culture)
        {
            return @this.ToString("D", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005年11月5日
        /// </summary>
        public static string ToLongDateString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("D", culture);
        }
        #endregion

        #region T 14:23:23
        /// <summary>
        /// 14:23:23
        /// </summary>
        public static string ToLongTimeString(this DateTime @this)
        {
            return @this.ToString("T", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 14:23:23
        /// </summary>
        public static string ToLongTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("T", new CultureInfo(culture));
        }

        /// <summary>
        /// 14:23:23
        /// </summary>
        public static string ToLongTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("T", culture);
        }
        #endregion

        #region m/M 11月5日
        /// <summary>
        /// 11月5日
        /// </summary>
        public static string ToMonthDayString(this DateTime @this)
        {
            return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 11月5日
        /// </summary>
        public static string ToMonthDayString(this DateTime @this, string culture)
        {
            return @this.ToString("m", new CultureInfo(culture));
        }

        /// <summary>
        /// 11月5日
        /// </summary>
        public static string ToMonthDayString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("m", culture);
        }
        #endregion

        #region r/R Sat, 05 Nov 2005 14:23:23 GMT
        /// <summary>
        /// Sat, 05 Nov 2005 14:23:23 GMT
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToRFC1123String(this DateTime @this)
        {
            return @this.ToString("r", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// Sat, 05 Nov 2005 14:23:23 GMT
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToRFC1123String(this DateTime @this, string culture)
        {
            return @this.ToString("r", new CultureInfo(culture));
        }

        /// <summary>
        /// Sat, 05 Nov 2005 14:23:23 GMT
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToRFC1123String(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("r", culture);
        }
        #endregion

        #region G 2005-11-5 14:23:23
        /// <summary>
        ///  2005-11-5 14:23:23
        /// </summary>
        public static string ToShortDateLongTimeString(this DateTime @this)
        {
            return @this.ToString("G", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005-11-5 14:23:23
        /// </summary>
        public static string ToShortDateLongTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("G", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005-11-5 14:23:23
        /// </summary>
        public static string ToShortDateLongTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("G", culture);
        }
        #endregion

        #region d 2005-11-5
        /// <summary>
        /// 2005-11-5
        /// </summary>
        public static string ToShortDateString(this DateTime @this)
        {
            return @this.ToString("d", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005-11-5
        /// </summary>
        public static string ToShortDateString(this DateTime @this, string culture)
        {
            return @this.ToString("d", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005-11-5
        /// </summary>
        public static string ToShortDateString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("d", culture);
        }
        #endregion

        #region g 2005-11-5 14:23
        /// <summary>
        /// 2005-11-5 14:23
        /// </summary>
        public static string ToShortDateTimeString(this DateTime @this)
        {
            return @this.ToString("g", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005-11-5 14:23
        /// </summary>
        public static string ToShortDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("g", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005-11-5 14:23
        /// </summary>
        public static string ToShortDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("g", culture);
        }
        #endregion

        #region t 14:23
        /// <summary>
        /// 14:23
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortTimeString(this DateTime @this)
        {
            return @this.ToString("t", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 14:23
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("t", new CultureInfo(culture));
        }

        /// <summary>
        /// 14:23
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToShortTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("t", culture);
        }
        #endregion

        #region s 2005-11-05T14:23:23
        /// <summary>
        /// 2005-11-05T14:23:23
        /// </summary>
        public static string ToSortableDateTimeString(this DateTime @this)
        {
            return @this.ToString("s", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005-11-05T14:23:23
        /// </summary>
        public static string ToSortableDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("s", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005-11-05T14:23:23
        /// </summary>
        public static string ToSortableDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("s", culture);
        }
        #endregion

        #region u 2005-11-05 14:23:23Z
        /// <summary>
        /// 2005-11-05 14:23:23Z
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this)
        {
            return @this.ToString("u", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005-11-05 14:23:23Z
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("u", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005-11-05 14:23:23Z
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>The given data converted to a string.</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("u", culture);
        }
        #endregion

        #region U 2005年11月5日 6:23:23
        /// <summary>
        /// 2005年11月5日 6:23:23
        /// </summary>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
        {
            return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005年11月5日 6:23:23
        /// </summary>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("U", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005年11月5日 6:23:23
        /// </summary>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("U", culture);
        }
        #endregion

        #region Y/y 2005年11月
        /// <summary>
        /// 2005年11月
        /// </summary>
        public static string ToYearMonthString(this DateTime @this)
        {
            return @this.ToString("y", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 2005年11月
        /// </summary>
        public static string ToYearMonthString(this DateTime @this, string culture)
        {
            return @this.ToString("y", new CultureInfo(culture));
        }

        /// <summary>
        /// 2005年11月
        /// </summary>
        public static string ToYearMonthString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("y", culture);
        }
        #endregion
    }
}
