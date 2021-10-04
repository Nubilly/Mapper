using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mapper.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serviceProvider = new ServiceCollection().AddMapper().BuildServiceProvider();

            var mapper = serviceProvider.GetRequiredService<IMapperFactory>();

            Dog dog = new Dog { Name = "Dog"};

            var seconddog = mapper.Map<Dog, SecondDog>(dog);

            Assert.AreEqual(dog.Name, seconddog.Name);

            var secondAsyncdog = mapper.MapAsync<Dog, SecondDog>(dog).Result;

            Assert.AreEqual(dog.Name, secondAsyncdog.Name);
        }
    }
}
