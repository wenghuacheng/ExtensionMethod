using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace ExtensionMethods.Core
{
    public static class StringExtensions
    {
        #region Concat
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static String Concat(this String str0, String str1)
        {
            return String.Concat(str0, str1);
        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static String Concat(this String str0, String str1, String str2)
        {
            return String.Concat(str0, str1, str2);
        }

        /// <summary>
        ///  连接字符串
        /// </summary>
        public static String Concat(this String str0, String str1, String str2, String str3)
        {
            return String.Concat(str0, str1, str2, str3);
        }
        #endregion

        #region Copy
        /// <summary>
        /// 拷贝字符串
        /// </summary>
        public static String Copy(this String str)
        {
            return String.Copy(str);
        }
        #endregion

        #region Format
        /// <summary>
        /// 格式化字符串
        /// </summary>
        public static String Format(this String format, Object arg0)
        {
            return String.Format(format, arg0);
        }

        /// <summary>
        /// 格式化字符串
        /// </summary>s>
        public static String Format(this String format, Object arg0, Object arg1)
        {
            return String.Format(format, arg0, arg1);
        }

        /// <summary>
        /// 格式化字符串
        /// </summary>
        public static String Format(this String format, Object arg0, Object arg1, Object arg2)
        {
            return String.Format(format, arg0, arg1, arg2);
        }

        /// <summary>
        /// 格式化字符串
        /// </summary>
        public static String Format(this String format, Object[] args)
        {
            return String.Format(format, args);
        }
        #endregion

        /// <summary>
        /// 是否是空字符串
        /// </summary>
        public static Boolean IsNullOrWhiteSpace(this String value)
        {
            return String.IsNullOrWhiteSpace(value);
        }

        #region Join
        /// <summary>
        /// 字符元素连接
        /// </summary>
        public static String Join(this String separator, String[] value)
        {
            return String.Join(separator, value);
        }

        /// <summary>
        /// 字符元素连接
        /// </summary>
        public static String Join(this String separator, Object[] values)
        {
            return String.Join(separator, values);
        }

        /// <summary>
        /// 字符元素连接
        /// </summary>
        public static String Join<T>(this String separator, IEnumerable<T> values)
        {
            return String.Join(separator, values);
        }

        /// <summary>
        /// 字符元素连接
        /// </summary>
        public static String Join(this String separator, IEnumerable<String> values)
        {
            return String.Join(separator, values);
        }

        /// <summary>
        /// 字符元素连接
        /// </summary>
        public static String Join(this String separator, String[] value, Int32 startIndex, Int32 count)
        {
            return String.Join(separator, value, startIndex, count);
        }
        #endregion

        #region Regex
        /// <summary>
        /// 是否匹配正则
        /// </summary>
        public static Boolean IsMatch(this String input, String pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        /// <summary>
        /// 是否匹配正则
        /// </summary>
        public static Boolean IsMatch(this String input, String pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }

        /// <summary>
        /// 获取第一个匹配项
        /// </summary>
        public static Match Match(this String input, String pattern)
        {
            return Regex.Match(input, pattern);
        }

        /// <summary>
        /// 获取第一个匹配项
        /// </summary>
        public static Match Match(this String input, String pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }

        /// <summary>
        /// 获取所有匹配项
        /// </summary>
        public static MatchCollection Matches(this String input, String pattern)
        {
            return Regex.Matches(input, pattern);
        }

        /// <summary>
        /// 获取所有匹配项
        /// </summary>
        public static MatchCollection Matches(this String input, String pattern, RegexOptions options)
        {
            return Regex.Matches(input, pattern, options);
        }
        #endregion

        #region HttpUtility
        /// <summary>
        /// 将字符串最小限度地转换为 HTML 编码的字符串
        /// </summary>
        public static String HtmlAttributeEncode(this String s)
        {
            return HttpUtility.HtmlAttributeEncode(s);
        }

        /// <summary>
        /// 将已经为 HTTP 传输进行过 HTML 编码的字符串转换为已解码的字符串
        /// </summary>
        public static String HtmlDecode(this String s)
        {
            return HttpUtility.HtmlDecode(s);
        }

        /// <summary>
        /// 对字符串进行编码
        /// </summary>
        public static String JavaScriptStringEncode(this String value)
        {
            return HttpUtility.JavaScriptStringEncode(value);
        }

        /// <summary>
        /// 将已经为在 URL 中传输而编码的字符串转换为解码的字符串
        /// </summary>
        public static String UrlDecode(this String str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        ///  将已经为在 URL 中传输而编码的字符串转换为解码的字符串
        /// </summary>
        public static String UrlDecode(this String str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }

        /// <summary>
        /// 使用指定的解码对象将 URL 编码的字符串转换为已解码的字节数组
        /// </summary>
        public static Byte[] UrlDecodeToBytes(this String str)
        {
            return HttpUtility.UrlDecodeToBytes(str);
        }

        /// <summary>
        /// 使用指定的解码对象将 URL 编码的字符串转换为已解码的字节数组
        /// </summary>
        public static Byte[] UrlDecodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlDecodeToBytes(str, e);
        }

        /// <summary>
        ///  对 URL 字符串进行编码
        /// </summary>
        public static String UrlEncode(this String str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///  对 URL 字符串进行编码
        /// </summary>
        public static String UrlEncode(this String str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }

        /// <summary>
        ///  使用指定的编码对象将字符串转换为 URL 编码的字节数组
        /// </summary>
        public static Byte[] UrlEncodeToBytes(this String str)
        {
            return HttpUtility.UrlEncodeToBytes(str);
        }

        /// <summary>
        ///  使用指定的编码对象将字符串转换为 URL 编码的字节数组
        /// </summary>
        public static Byte[] UrlEncodeToBytes(this String str, Encoding e)
        {
            return HttpUtility.UrlEncodeToBytes(str, e);
        }

        /// <summary>
        /// 对 URL 字符串的路径部分进行编码，以进行从 Web 服务器到客户端的可靠的 HTTP 传输
        /// </summary>
        public static String UrlPathEncode(this String str)
        {
            return HttpUtility.UrlPathEncode(str);
        }
        #endregion
    }
}
