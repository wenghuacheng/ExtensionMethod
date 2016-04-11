using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Compression.GZip
{
    public static class FileInfoExtensions
    {
        #region CreateZip
        /// <summary>
        /// 将文件压缩
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        public static void CreateGZip(this FileInfo @this)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(@this.FullName + ".gz"))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// 将文件压缩
        /// </summary>
        /// <param name="this"></param>
        /// <param name="destination">压缩文件完整路径</param>
        public static void CreateGZip(this FileInfo @this, string destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// 将文件压缩
        /// </summary>
        /// <param name="this"></param>
        /// <param name="destination">目标压缩文件</param>
        public static void CreateGZip(this FileInfo @this, FileInfo destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        #endregion

        #region ExtractGZipToDirectory
        /// <summary>
        /// 将文件解压
        /// </summary>
        /// <param name="this"></param>
        public static void ExtractGZipToDirectory(this FileInfo @this)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                string newFileName = Path.GetFileNameWithoutExtension(@this.FullName);

                using (FileStream decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        /// <summary>
        /// 将文件解压
        /// </summary>
        /// <param name="this"></param>
        /// <param name="destination">解压文件路径</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, string destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// 将文件解压
        /// </summary>
        /// <param name="this"></param>
        /// <param name="destination">解压文件</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, FileInfo destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream compressedFileStream = File.Create(destination.FullName))
                {
                    using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(compressionStream);
                    }
                }
            }
        }
        #endregion
    }
}
