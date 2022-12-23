using EasyMicroservice.Utilities.Constants;
using Xunit;

namespace EasyMicroservice.Utilities.Tests.Constants
{
    public class HttpHeadersConstantsTest
    {
        [Theory]
        [InlineData(HttpHeadersConstants.ContentLength, "content-length")]
        public void CheckValues(string value, string expect)
        {
            Assert.Equal(value, expect);
        }
    }
}
