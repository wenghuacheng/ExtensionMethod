using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class IDictionaryStringObjectExtensions
    {
        /// <summary>
        /// 将IDictionary转换为动态类型
        /// </summary>
        /// <param name="this">IDictionary</param>
        /// <returns>ExpandoObject</returns>
        public static ExpandoObject ToExpando(this IDictionary<string, object> @this)
        {
            var expando = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>)expando;

            foreach (var item in @this)
            {
                if (item.Value is IDictionary<string, object>)
                {
                    var d = (IDictionary<string, object>)item.Value;
                    expandoDict.Add(item.Key, d.ToExpando());
                }
                else
                {
                    expandoDict.Add(item);
                }
            }

            return expando;
        }
    }
}
