using Mapper.Tests.Mappers;
using Mapper.Tests.Models;
using Xunit;

namespace Mapper.Tests
{
    public class MapperAsyncShould
    {
        private readonly DogAsyncMapper DogAsyncMapper;
        private readonly Dog Dog;

        public MapperAsyncShould()
        {
            DogAsyncMapper = new DogAsyncMapper();
            Dog = new Dog { Name = "Dog" };
        }

        [Fact]
        public void IsTypeOfMapper() => Assert.IsAssignableFrom<IMapperAsync<Dog, SecondDog>>(DogAsyncMapper);

        [Fact]
        public void NameMapped()
        {           
            var secondAsyncdog = DogAsyncMapper.MapAsync(Dog).Result;

            Assert.Equal(Dog.Name, secondAsyncdog.Name);
        }
    }
}

