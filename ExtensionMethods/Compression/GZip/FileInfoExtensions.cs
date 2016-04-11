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
        ///     A FileInfo extension method that creates a zip file.
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
        ///     A FileInfo extension method that creates a zip file.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the zip.</param>
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
        ///     A FileInfo extension method that creates a zip file.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the zip.</param>
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
        ///     A FileInfo extension method that extracts the g zip to directory described by
        ///     @this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
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
        ///     A FileInfo extension method that extracts the g zip to directory described by
        ///     @this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the.</param>
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
        ///     A FileInfo extension method that extracts the g zip to directory described by
        ///     @this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="destination">Destination for the.</param>
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
