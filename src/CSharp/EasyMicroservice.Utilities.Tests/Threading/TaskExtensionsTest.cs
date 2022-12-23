using EasyMicroservice.Utilities.Threading.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservice.Utilities.Tests.Threading
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