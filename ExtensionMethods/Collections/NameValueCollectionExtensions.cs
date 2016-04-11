using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class NameValueCollectionExtensions
    {
        /// <summary>
        /// 将NameValueCollection转换为IDictionary
        /// </summary>
        /// <param name="this">NameValueCollection</param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary(this NameValueCollection @this)
        {
            var dict = new Dictionary<string, object>();

            if (@this != null)
            {
                foreach (string key in @this.AllKeys)
                {
                    dict.Add(key, @this[key]);
                }
            }

            return dict;
        }
    }
}
