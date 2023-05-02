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
    }
}
