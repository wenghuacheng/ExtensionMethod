using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class BooleanExtensions
    {
        /// <summary>
        /// false时执行的操作
        /// </summary>
        public static void IfFalse(this bool @this, Action action)
        {
            if (!@this)
            {
                action();
            }
        }

        /// <summary>
        /// true时执行的操作
        /// </summary>
        public static void IfTrue(this bool @this, Action action)
        {
            if (@this)
            {
                action();
            }
        }

        /// <summary>
        /// 将bool值转换为字节
        /// </summary>
        public static byte ToBinary(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}
