using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class IDictionaryStringStringExtensions
    {
        /// <summary>
        /// 将IDictionary转为NameValueCollection
        /// </summary>
        /// <param name="this">IDictionary</param>
        /// <returns>NameValueCollection</returns>
        public static NameValueCollection ToNameValueCollection(this IDictionary<string, string> @this)
        {
            if (@this == null)
            {
                return null;
            }

            var col = new NameValueCollection();
            foreach (var item in @this)
            {
                col.Add(item.Key, item.Value);
            }
            return col;
        }
    }
}
