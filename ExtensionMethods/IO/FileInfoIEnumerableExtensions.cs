using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtensionMethods.IO
{
    public static class FileInfoIEnumerableExtensions
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        public static void Delete(this IEnumerable<FileInfo> @this)
        {
            foreach (FileInfo t in @this)
            {
                t.Delete();
            }
        }

        /// <summary>
        ///  遍历文件夹下的所有文件并执行操作
        /// </summary>
        public static IEnumerable<FileInfo> ForEach(this IEnumerable<FileInfo> @this, Action<FileInfo> action)
        {
            foreach (FileInfo t in @this)
            {
                action(t);
            }
            return @this;
        }

    }
}
