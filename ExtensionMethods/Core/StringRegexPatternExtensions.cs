using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods.Core
{
    public static class StringRegexPatternExtensions
    {
        /// <summary>
        /// 是否是Url
        /// </summary>
        public static bool IsValidUrl(this string obj)
        {
            return obj.IsMatch(@"^http://([\w-]+\.)+[\w-]+(/[\w-./?%&=]*)?$");
        }

        /// <summary>
        /// 是否是邮箱
        /// </summary>
        public static bool IsValidEmail(this string obj)
        {
            return obj.IsMatch(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }

        /// <summary>
        /// 是否是电话/传真号
        /// </summary>
        public static bool IsValidTelephone(this string obj)
        {
            return obj.IsMatch(@"((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)");
        }

        /// <summary>
        /// 是否是移动电话号码
        /// </summary>
        public static bool IsValidMobilephone(this string obj)
        {
            return obj.IsMatch(@"^[1][34578][0-9]{9}$");
        }

        /// <summary>
        /// 是否是邮政编码
        /// </summary>
        public static bool IsZipcode(this string obj)
        {
            return obj.IsMatch(@"[1-9]\d{5}(?!\d)");
        }
    }
}
