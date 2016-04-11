using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Compression.GZip
{
    public static class StringExtensions
    {
        /// <summary>
        /// 将String转为字节数组
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static byte[] CompressGZip(this string @this)
        {
            byte[] stringAsBytes = Encoding.Default.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }

        /// <summary>
        /// 将String按指定编码转为字节数组
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">编码</param>
        /// <returns></returns>
        public static byte[] CompressGZip(this string @this, Encoding encoding)
        {
            byte[] stringAsBytes = encoding.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                    zipStream.Close();
                    return (memoryStream.ToArray());
                }
            }
        }
    }
}
