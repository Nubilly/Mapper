using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Xunit;

namespace Mapper.Tests
{
    public class MapperExtensionsShould
    {
        [Fact]
        public void Test1()
        {
            var serviceProvider = new ServiceCollection().AddMapper().BuildServiceProvider();
        }
    }
}