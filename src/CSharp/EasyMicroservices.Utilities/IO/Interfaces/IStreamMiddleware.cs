using System.IO;
using System.Threading.Tasks;

namespace EasyMicroservices.Utilities.IO.Interfaces
{
    /// <summary>
    /// this Middleware help you to make a wrapper to use stream
    /// for example compress a stream and encrypt it
    /// </summary>
    public interface IStreamMiddleware
    {
        /// <summary>
        /// inner middleware
        /// </summary>
        public IStreamMiddleware InnerStreamMiddleware { get; set; }
        /// <summary>
        /// get stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public Task<Stream> GetStream(Stream stream);
    }
}
