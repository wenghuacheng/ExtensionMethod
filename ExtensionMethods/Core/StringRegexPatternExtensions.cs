using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods.Core
{
    public static class StringRegexPatternExtensions
    {
        #region 正则表达式
        //注:如需提取字符串中的信息如身份证只需将@"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$"中的起始和开头的^和$去掉

        //Url
        public const string UrlRegexString = @"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$";
        //加强版Url
        public const string Url2RegexString = @"^(https?|s?ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$";
        //邮箱
        public const string EmailRegexString = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        //电话/传真号
        public const string TelephoneRegexString = @"((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)";
        //移动电话号码
        public const string MobilephoneRegexString = @"^[1][34578][0-9]{9}$";
        //邮政编码
        public const string ZipcodeRegexString = @"[1-9]\d{5}(?!\d)";
        //身份证号
        public const string IDCardRegexString = @"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$";
        //检测密码复杂度是否达标：密码中必须包含字母、数字、特称字符，至少8个字符，最多16个字符。
        public const string PasswordRegexString = @"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,16}$";
        #endregion

        #region 是否匹配
        /// <summary>
        /// 是否是Url(常用)
        /// </summary>
        public static bool IsValidUrl(this string obj)
        {
            return obj.IsMatch(UrlRegexString);
        }

        /// <summary>
        /// 是否是Url(包含https和中文的url)
        /// </summary>
        public static bool IsValidUrlWhole(this string obj)
        {
            return obj.IsMatch(Url2RegexString);
        }

        /// <summary>
        /// 是否是邮箱
        /// </summary>
        public static bool IsValidEmail(this string obj)
        {
            return obj.IsMatch(EmailRegexString);
        }

        /// <summary>
        /// 是否是电话/传真号
        /// </summary>
        public static bool IsValidTelephone(this string obj)
        {
            return obj.IsMatch(TelephoneRegexString);
        }

        /// <summary>
        /// 是否是移动电话号码
        /// </summary>
        public static bool IsValidMobilephone(this string obj)
        {
            return obj.IsMatch(MobilephoneRegexString);
        }

        /// <summary>
        /// 是否是邮政编码
        /// </summary>
        public static bool IsZipcode(this string obj)
        {
            return obj.IsMatch(ZipcodeRegexString);
        }

        /// <summary>
        /// 是否是身份证号
        /// </summary>
        public static bool IsIDCard(this string obj)
        {
            return obj.IsMatch(IDCardRegexString);
        }

        /// <summary>
        /// 密码中必须包含字母、数字、特称字符，至少8个字符，最多16个字符
        /// </summary>
        public static bool IsGoodPassword(this string obj)
        {
            return obj.IsMatch(PasswordRegexString);
        }

        #endregion

        #region Extract
        /// <summary>
        /// 截取字符串中开始和结束字符串中间的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="startStr">开始字符串</param>
        /// <param name="endStr">结束字符串</param>
        /// <returns>中间字符串</returns>
        public static string Substring(this string source, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(source).Value;
        }
        #endregion
    }
}
