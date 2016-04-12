using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtensionMethods.IO
{
    public static class DirectoryInfoIEnumerableExtensions
    {
        /// <summary>
        /// 删除所有文件夹
        /// </summary>
        public static void Delete(this IEnumerable<DirectoryInfo> @this)
        {
            foreach (DirectoryInfo t in @this)
            {
                t.Delete();
            }
        }

        /// <summary>
        /// 针对此文件夹下的所有文件夹处理
        /// </summary>
        public static IEnumerable<DirectoryInfo> ForEach(this IEnumerable<DirectoryInfo> @this, Action<DirectoryInfo> action)
        {
            foreach (DirectoryInfo t in @this)
            {
                action(t);
            }
            return @this;
        }
    }
}
