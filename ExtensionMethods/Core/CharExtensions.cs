using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class CharExtensions
    {
        /// <summary>
        ///  将指定的数字 Unicode 字符转换为双精度浮点数。.
        /// </summary>
        /// <param name="c">要转换的 Unicode 字符</param>
        /// <returns>如果该字符表示数字，则为 c 的数值；否则为 -1.0</returns>
        public static Double GetNumericValue(this Char c)
        {
            return Char.GetNumericValue(c);
        }

        #region 类型判别
        /// <summary>
        /// 指示指定的 Unicode 字符是否属于控制字符类别
        /// </summary>
        public static Boolean IsControl(this Char c)
        {
            return Char.IsControl(c);
        }

        /// <summary>
        /// 指示指定字符串中位于指定位置处的字符是否属于十进制数字类别
        /// </summary>
        public static Boolean IsDigit(this Char c)
        {
            return Char.IsDigit(c);
        }

        /// <summary>
        /// 指示是否将指定的 Unicode 字符分类为 Unicode 字母
        /// </summary>
        public static Boolean IsLetter(this Char c)
        {
            return Char.IsLetter(c);
        }

        /// <summary>
        /// 指示将指定的 Unicode 字符分类为字母还是十进制数字。
        /// </summary>
        public static Boolean IsLetterOrDigit(this Char c)
        {
            return Char.IsLetterOrDigit(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于小写字母类别
        /// </summary>
        public static Boolean IsLower(this Char c)
        {
            return Char.IsLower(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于数字类别
        /// </summary>
        public static Boolean IsNumber(this Char c)
        {
            return Char.IsNumber(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于标点符号类别
        /// </summary>
        public static Boolean IsPunctuation(this Char c)
        {
            return Char.IsPunctuation(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于分隔符类别
        /// </summary>
        public static Boolean IsSeparator(this Char c)
        {
            return Char.IsSeparator(c);
        }
        

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于符号字符类别
        /// </summary>
        public static Boolean IsSymbol(this Char c)
        {
            return Char.IsSymbol(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于大写字母类别
        /// </summary>
        public static Boolean IsUpper(this Char c)
        {
            return Char.IsUpper(c);
        }

        /// <summary>
        /// 指示指定的 Unicode 字符是否属于空白类别
        /// </summary>
        public static Boolean IsWhiteSpace(this Char c)
        {
            return Char.IsWhiteSpace(c);
        }
        #endregion

        #region To
        /// <summary>
        /// 使用指定的区域性特定格式设置信息将指定 Unicode 字符的值转换为它的小写等效项
        /// </summary>
        /// <param name="c">要转换的 Unicode 字符</param>
        /// <param name="culture">提供区域性特定的大小写规则的对象，或 null</param>
        public static Char ToLower(this Char c, CultureInfo culture)
        {
            return Char.ToLower(c, culture);
        }

        /// <summary>
        /// 使用指定的区域性特定格式设置信息将指定 Unicode 字符的值转换为它的小写等效项
        /// </summary>
        /// <param name="c">要转换的 Unicode 字符</param>
        public static Char ToLower(this Char c)
        {
            return Char.ToLower(c);
        }
              

        /// <summary>
        /// 使用指定的区域性特定格式设置信息将指定 Unicode 字符的值转换为它的大写等效项
        /// </summary>
        /// <param name="c">要转换的 Unicode 字符</param>
        /// <param name="culture">提供区域性特定的大小写规则的对象，或 null</param>
        public static Char ToUpper(this Char c, CultureInfo culture)
        {
            return Char.ToUpper(c, culture);
        }

        /// <summary>
        /// 使用指定的区域性特定格式设置信息将指定 Unicode 字符的值转换为它的大写等效项
        /// </summary>
        /// <param name="c">要转换的 Unicode 字符</param>
        public static Char ToUpper(this Char c)
        {
            return Char.ToUpper(c);
        }              
        #endregion

        /// <summary>
        /// 字符是否不在字符数组中
        /// </summary>
        /// <param name="this">字符</param>
        /// <param name="values">字符数组</param>
        public static bool NotIn(this Char @this, params Char[] values)
        {
            return Array.IndexOf(values, @this) == -1;
        }

        /// <summary>
        ///  字符是否在字符数组中
        /// </summary>
        /// <param name="this">字符</param>
        /// <param name="values">字符数组</param>
        public static bool In(this Char @this, params Char[] values)
        {
            return Array.IndexOf(values, @this) != -1;
        }

        /// <summary>
        /// 重复生成相同字符组成的字符串
        /// </summary>
        /// <param name="this">字符</param>
        /// <param name="repeatCount">重复次数</param>
        public static string Repeat(this char @this, int repeatCount)
        {
            return new string(@this, repeatCount);
        }

        /// <summary>
        /// 生成从@this到指定字符之间的所有字符数组
        /// </summary>
        /// <param name="this">起始/结束字符</param>
        /// <param name="toCharacter">起始/结束字符</param>
        /// <returns>会根据@this与toCharacter大小自动进行排序</returns>
        public static IEnumerable<char> To(this char @this, char toCharacter)
        {
            bool reverseRequired = (@this > toCharacter);

            char first = reverseRequired ? toCharacter : @this;
            char last = reverseRequired ? @this : toCharacter;

            IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }


            return result;
        }
    }
}
