﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class IDictionaryStringStringExtensions
    {
        /// <summary>
        ///     An IDictionary&lt;string,string&gt; extension method that converts the @this to a name value collection.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>@this as a NameValueCollection.</returns>
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