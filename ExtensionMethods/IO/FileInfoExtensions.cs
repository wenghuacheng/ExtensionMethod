using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExtensionMethods.IO
{
    public static class FileInfoExtensions
    {
        /// <summary>
        /// 文件追加内容
        /// </summary>
        public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents)
        {
            File.AppendAllLines(@this.FullName, contents);
        }

        /// <summary>
        /// 文件追加内容
        /// </summary>
        public static void AppendAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
        {
            File.AppendAllLines(@this.FullName, contents, encoding);
        }

        /// <summary>
        /// 文件追加文本
        /// </summary>
        public static void AppendAllText(this FileInfo @this, String contents)
        {
            File.AppendAllText(@this.FullName, contents);
        }

        /// <summary>
        /// 文件追加文本
        /// </summary>
        public static void AppendAllText(this FileInfo @this, String contents, Encoding encoding)
        {
            File.AppendAllText(@this.FullName, contents, encoding);
        }

        /// <summary>
        /// 改变文件后缀
        /// </summary>
        public static String ChangeExtension(this FileInfo @this, String extension)
        {
            return Path.ChangeExtension(@this.FullName, extension);
        }

        /// <summary>
        /// 获取文件所在的文件夹路径
        /// </summary>
        public static String GetDirectoryFullName(this FileInfo @this)
        {
            return @this.Directory.FullName;
        }

        /// <summary>
        /// 获取文件所在的文件夹名
        /// </summary>
        public static String GetDirectoryName(this FileInfo @this)
        {
            return @this.Directory.Name;
        }

        /// <summary>
        /// 返回不具有扩展名的指定路径字符串的文件名
        /// </summary>
        public static String GetFileNameWithoutExtension(this FileInfo @this)
        {
            return Path.GetFileNameWithoutExtension(@this.FullName);
        }

        /// <summary>
        /// 是否包含扩展名
        /// </summary>
        public static Boolean HasExtension(this FileInfo @this)
        {
            return Path.HasExtension(@this.FullName);
        }

        /// <summary>
        /// 获取文件字节数组
        /// </summary>
        public static Byte[] ReadAllBytes(this FileInfo @this)
        {
            return File.ReadAllBytes(@this.FullName);
        }

        /// <summary>
        /// 获取文件内容
        /// </summary>
        public static String[] ReadAllLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadAllLines(@this.FullName, encoding);
        }

        /// <summary>
        /// 获取文件文本
        /// </summary>
        public static String ReadAllText(this FileInfo @this)
        {
            return File.ReadAllText(@this.FullName);
        }

        /// <summary>
        /// 获取文件文本
        /// </summary>
        public static string ReadToEnd(this FileInfo @this)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 获取文件文本
        /// </summary>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding)
        {
            using (FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 文件重命名
        /// </summary>
        public static void Rename(this FileInfo @this, string newName)
        {
            string filePath = Path.Combine(@this.Directory.FullName, newName);
            @this.MoveTo(filePath);
        }

        /// <summary>
        /// 文件扩展名重命名
        /// </summary>
        public static void RenameExtension(this FileInfo @this, String extension)
        {
            string filePath = Path.ChangeExtension(@this.FullName, extension);
            @this.MoveTo(filePath);
        }

        /// <summary>
        /// 文件重命名不带扩展名
        /// </summary>
        public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
        {
            string fileName = string.Concat(newName, @this.Extension);
            string filePath = Path.Combine(@this.Directory.FullName, fileName);
            @this.MoveTo(filePath);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        public static void WriteAllBytes(this FileInfo @this, Byte[] bytes)
        {
            File.WriteAllBytes(@this.FullName, bytes);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents)
        {
            File.WriteAllLines(@this.FullName, contents);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        public static void WriteAllLines(this FileInfo @this, IEnumerable<String> contents, Encoding encoding)
        {
            File.WriteAllLines(@this.FullName, contents, encoding);
        }

        /// <summary>
        /// 写文件
        /// </summary>
        public static void WriteAllText(this FileInfo @this, String contents, Encoding encoding)
        {
            File.WriteAllText(@this.FullName, contents, encoding);
        }
    }
}
