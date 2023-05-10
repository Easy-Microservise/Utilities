using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMicroservices.Utilities.IO
{
    /// <summary>
    /// stream helper
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// convert a stream to byte array
        /// </summary>
        /// <param name="fromStream">stream to read</param>
        /// <param name="length">length of data to read</param>
        /// <param name="bufferSize">buffer size to read</param>
        /// <param name="cancellationToken">cancel token</param>
        /// <returns>byte array readed from stream</returns>
        public static async Task<byte[]> StreamToBytesAsync(this Stream fromStream, long length, int bufferSize, CancellationToken cancellationToken = default)
        {
            if (length == 0)
                return new byte[0];
            if (fromStream.CanSeek)
                fromStream.Seek(0, SeekOrigin.Begin);
            byte[] result = new byte[length];
            var readBytes = new byte[bufferSize];
            long writed = 0;
            while (writed < length)
            {
                int readCount;
                if (readBytes.Length > length - writed)
                    readBytes = new byte[length - writed];
                readCount = await fromStream.ReadAsync(readBytes, 0, readBytes.Length, cancellationToken);
                if (readCount <= 0)
                    throw new Exception("Client disconnected! I read zero buffer from stream, Maybe stream disposed before I read data.");
                for (int i = 0; i < readCount; i++)
                {
                    result[writed + i] = readBytes[i];
                }
                writed += readCount;
            }
            return result;
        }

        /// <summary>
        /// convert a stream to byte array
        /// </summary>
        /// <param name="fromStream">stream to read</param>
        /// <param name="bufferSize">buffer size to read</param>
        /// <param name="cancellationToken">cancel token</param>
        /// <returns>byte array readed from stream</returns>
        public static async Task<byte[]> StreamToBytesAsync(this Stream fromStream, int bufferSize, CancellationToken cancellationToken = default)
        {
            if (fromStream.CanSeek)
                fromStream.Seek(0, SeekOrigin.Begin);
            using MemoryStream result = new MemoryStream();
            var readBytes = new byte[bufferSize];
            do
            {
                int readCount;
                readCount = await fromStream.ReadAsync(readBytes, 0, readBytes.Length, cancellationToken);
                if (readCount <= 0)
                    break;
                await result.WriteAsync(readBytes, 0, readCount);
            }
            while (true);
            return result.ToArray();
        }

        /// <summary>
        /// copy a stream to another
        /// </summary>
        /// <param name="fromStream">stream to read</param>
        /// <param name="writeStream">stream to write</param>
        /// <param name="length">length of data to read</param>
        /// <param name="bufferSize">buffer size to read</param>
        /// <param name="cancellationToken">cancel token</param>
        public static async Task CopyStreamToStreamAsync(this Stream fromStream, Stream writeStream, long length, int bufferSize, CancellationToken cancellationToken = default)
        {
            if (length <= 0)
                throw new Exception("Length is not valid.");
            if (fromStream.CanSeek)
                fromStream.Seek(0, SeekOrigin.Begin);
            var readBytes = new byte[bufferSize];
            long writed = 0;
            while (writed < length)
            {
                int readCount;
                if (readBytes.Length > length - writed)
                    readBytes = new byte[length - writed];
                readCount = await fromStream.ReadAsync(readBytes, 0, readBytes.Length, cancellationToken);
                if (readCount <= 0)
                    throw new Exception("Client disconnected! I read zero buffer from stream, Maybe stream disposed before I read data.");
                await writeStream.WriteAsync(readBytes, 0, readCount);
                writed += readCount;
            }
        }
    }
}
