using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservices.Utilities.Tests.Threading
{
    public class TaskExtensionsTest
    {
        [Fact]
        public async Task GetCompletedTask()
        {
            await TaskHelper.GetCompletedTask();
        }
    }
}