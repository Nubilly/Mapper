using Mapper.Tests.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mapper.Tests
{
    public class MapperFactoryShould
    {
        [Fact]
        public void test()
        {
            var serviceProvider = new ServiceCollection().AddMapper().BuildServiceProvider();

            var mapper = serviceProvider.GetRequiredService<IMapperFactory>();

            Dog dog = new Dog { Name = "Dog" };

            var seconddog = mapper.Map<Dog, SecondDog>(dog);

            Assert.Equal(dog.Name, seconddog.Name);

            var secondAsyncdog = mapper.MapAsync<Dog, SecondDog>(dog).Result;

            Assert.Equal(dog.Name, secondAsyncdog.Name);
        }
    }
}
