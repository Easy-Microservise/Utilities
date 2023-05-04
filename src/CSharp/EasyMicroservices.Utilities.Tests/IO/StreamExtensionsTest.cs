using EasyMicroservices.Utilities.IO;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservices.Utilities.Tests.IO
{
    public class StreamExtensionsTest
    {
        [Fact]
        public async Task StreamToBytesAsync()
        {
            using MemoryStream memoryStream = new MemoryStream();
            byte[] bytes = new byte[100];
            for (int i = 0; i < 100; i++)
            {
                bytes[i] = (byte)i;
                await memoryStream.WriteAsync(new byte[] { bytes[i] }, 0, 1);
            }

            var readBytes = await memoryStream.StreamToBytesAsync(100, 10);
            for (int i = 0; i < 100; i++)
            {
                Assert.Equal(readBytes[i], (byte)i);
            }
        }

        [Fact]
        public async Task CopyStreamToStreamAsync()
        {
            using MemoryStream memoryStream = new MemoryStream();
            byte[] bytes = new byte[100];
            for (int i = 0; i < 100; i++)
            {
                bytes[i] = (byte)i;
                await memoryStream.WriteAsync(new byte[] { bytes[i] }, 0, 1);
            }

            using MemoryStream writeStream = new MemoryStream();

            await memoryStream.CopyStreamToStreamAsync(writeStream, 100, 10);
            var readBytes = writeStream.ToArray();
            for (int i = 0; i < 100; i++)
            {
                Assert.Equal(readBytes[i], (byte)i);
            }
        }
    }
}
