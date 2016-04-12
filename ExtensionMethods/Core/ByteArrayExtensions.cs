using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ExtensionMethods.Core
{
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// 改变字节数组的大小
        /// </summary>
        /// <param name="this">数组</param>
        /// <param name="newSize">新长度</param>
        public static byte[] Resize(this byte[] @this, int newSize)
        {
            Array.Resize(ref @this, newSize);
            return @this;
        }

        /// <summary>
        /// 将字节数组转为Image类型
        /// </summary>
        /// <param name="this">数组</param>
        public static Image ToImage(this byte[] @this)
        {
            using (var ms = new MemoryStream(@this))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        ///  将字节数组转为MemoryStream类型
        /// </summary>
        /// <param name="this">数组</param>
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }

        #region ToBase64
        /// <summary>
        /// 将字节数组转为Base64编码
        /// </summary>
        public static String ToBase64String(this Byte[] inArray)
        {
            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// 将字节数组转为Base64编码
        /// </summary>
        /// <param name="options">方法是否在其输出中插入分行符</param>
        public static String ToBase64String(this Byte[] inArray, Base64FormattingOptions options)
        {
            return Convert.ToBase64String(inArray, options);
        }

        /// <summary>
        /// 将字节数组转为Base64编码
        /// </summary>
        /// <param name="inArray">数组</param>
        /// <param name="offset">起始位置</param>
        /// <param name="length">转换长度</param>
        public static String ToBase64String(this Byte[] inArray, Int32 offset, Int32 length)
        {
            return Convert.ToBase64String(inArray, offset, length);
        }

        /// <summary>
        /// 将字节数组转为Base64编码
        /// </summary>
        /// <param name="inArray">数组</param>
        /// <param name="offset">起始位置</param>
        /// <param name="length">转换长度</param>
        /// <param name="options">方法是否在其输出中插入分行符</param>
        public static String ToBase64String(this Byte[] inArray, Int32 offset, Int32 length, Base64FormattingOptions options)
        {
            return Convert.ToBase64String(inArray, offset, length, options);
        }
        #endregion

        #region Url
        /// <summary>
        /// 将字节数组转换为Base64编码适合url传输的字符串
        /// </summary>
        public static String UrlTokenEncode(this Byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }

        /// <summary>
        ///  使用指定的解码对象将 URL 编码的字节数组转换为已解码的字符串。
        /// </summary>
        /// <param name="bytes">要解码的字节数组</param>
        /// <param name="e">指定解码方法</param>
        public static String UrlDecode(this Byte[] bytes, Encoding e)
        {
            return HttpUtility.UrlDecode(bytes, e);
        }

        /// <summary>
        ///  将 URL 编码的字节数组转换为已解码的字节数组
        /// </summary>
        public static Byte[] UrlDecodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlDecodeToBytes(bytes);
        }

        /// <summary>
        ///  将字节数组转换为编码的 URL 字符串
        /// </summary>
        public static String UrlEncode(this Byte[] bytes)
        {
            return HttpUtility.UrlEncode(bytes);
        }
        
        /// <summary>
        ///  将字节数组转换为 URL 编码的字节数组
        /// </summary>
        public static Byte[] UrlEncodeToBytes(this Byte[] bytes)
        {
            return HttpUtility.UrlEncodeToBytes(bytes);
        }

        #endregion
    }
}
