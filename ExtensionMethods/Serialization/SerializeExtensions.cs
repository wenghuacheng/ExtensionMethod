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
    public static class SerializeExtensions
    {
        #region BinaryFormatter
        /// <summary>
        /// 二进制序列化
        /// </summary>
        public static string SerializeBinary<T>(this T @this)
        {
            var binaryWrite = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        /// 二进制序列化
        /// </summary>
        public static string SerializeBinary<T>(this T @this, Encoding encoding)
        {
            var binaryWrite = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return encoding.GetString(memoryStream.ToArray());
            }
        }
        #endregion

        #region JavaScriptSerializer
        /// <summary>
        /// 异步通信层内部使用
        /// </summary>
        public static string SerializeJavaScript<T>(this T @this)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(@this);
        }
        #endregion

        #region DataContractJsonSerializer
        /// <summary>
        /// Json序列化
        /// </summary>
        public static string SerializeJson<T>(this T @this)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, @this);
                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        /// Json序列化
        /// </summary>
        public static string SerializeJson<T>(this T @this, Encoding encoding)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, @this);
                return encoding.GetString(memoryStream.ToArray());
            }
        }
        #endregion

        #region XmlSerializer
        /// <summary>
        /// XML序列化
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>The string representation of the Xml Serialization.</returns>
        public static string SerializeXml(this object @this)
        {
            var xmlSerializer = new XmlSerializer(@this.GetType());

            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, @this);
                using (var streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
        #endregion
    }
}
