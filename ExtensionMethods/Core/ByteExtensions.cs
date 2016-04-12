using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class ByteExtensions
    {
        /// <summary>
        /// 获取最大的字符
        /// </summary>
        public static Byte Max(this Byte val1, Byte val2)
        {
            return Math.Max(val1, val2);
        }

        /// <summary>
        /// 获取最小的字符
        /// </summary>
        public static Byte Min(this Byte val1, Byte val2)
        {
            return Math.Min(val1, val2);
        }

    }
}