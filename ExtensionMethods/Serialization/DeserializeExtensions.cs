using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace ExtensionMethods.Serialization
{
    public static class DeserializeExtensions
    {
        #region BinaryFormatter
        /// <summary>
        /// 二进制反序列化
        /// </summary>
        public static T DeserializeBinary<T>(this string @this)
        {
            using (var stream = new MemoryStream(Encoding.Default.GetBytes(@this)))
            {
                var binaryRead = new BinaryFormatter();
                return (T)binaryRead.Deserialize(stream);
            }
        }

        /// <summary>
        /// 二进制反序列化
        /// </summary>
        public static T DeserializeBinary<T>(this string @this, Encoding encoding)
        {
            using (var stream = new MemoryStream(encoding.GetBytes(@this)))
            {
                var binaryRead = new BinaryFormatter();
                return (T)binaryRead.Deserialize(stream);
            }
        }
        #endregion

        #region JavaScriptSerializer
        /// <summary>
        /// 异步通信层内部使用
        /// </summary>
        public static T DeserializeJavaScript<T>(this string @this)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(@this);
        }
        #endregion

        #region DataContractJsonSerializer
        /// <summary>
        /// Json反序列化
        /// </summary>
        public static T DeserializeJson<T>(this string @this)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var stream = new MemoryStream(Encoding.Default.GetBytes(@this)))
            {
                return (T)serializer.ReadObject(stream);
            }
        }

        /// <summary>
        /// Json反序列化
        /// </summary>
        public static T DeserializeJson<T>(this string @this, Encoding encoding)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var stream = new MemoryStream(encoding.GetBytes(@this)))
            {
                return (T)serializer.ReadObject(stream);
            }
        }
        #endregion

        #region XmlSerializer
        /// <summary>
        /// Xml反序列化
        /// </summary>
        public static T DeserializeXml<T>(this string @this)
        {
            var x = new XmlSerializer(typeof(T));
            var r = new StringReader(@this);

            return (T)x.Deserialize(r);
        }
        #endregion
    }
}
