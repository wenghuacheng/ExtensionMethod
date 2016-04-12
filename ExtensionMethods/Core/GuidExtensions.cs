using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Core
{
    public static class GuidExtensions
    {
        /// <summary>GUID是否为空</summary>
        public static bool IsEmpty(this Guid @this)
        {
            return @this == Guid.Empty;
        }

        /// <summary>GUID是否不为空</summary>
        public static bool IsNotEmpty(this Guid @this)
        {
            return @this != Guid.Empty;
        }
    }
}
