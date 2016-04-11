using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Collections
{
    public static class IDictionaryExtensions
    {
        /// <summary>
        /// 将IDictionary转为hashtable
        /// </summary>
        /// <param name="this">IDictionary</param>
        /// <returns>Hashtable</returns>
        public static Hashtable ToHashtable(this IDictionary @this)
        {
            return new Hashtable(@this);
        }
    }
}
