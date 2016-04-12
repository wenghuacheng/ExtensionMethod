using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class DelegateExtensions
    {
        /// <summary>
        /// 合并委托
        /// </summary>
        public static Delegate Combine(this Delegate a, Delegate b)
        {
            return Delegate.Combine(a, b);
        }

        /// <summary>
        /// 委托移除
        /// </summary>
        public static Delegate Remove(this Delegate source, Delegate value)
        {
            return Delegate.Remove(source, value);
        }

        /// <summary>
        /// 移除所有相关委托
        /// </summary>
        public static Delegate RemoveAll(this Delegate source, Delegate value)
        {
            return Delegate.RemoveAll(source, value);
        }
    }
}
