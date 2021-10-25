using Mapper.Tests.Mappers;
using Mapper.Tests.Models;
using Xunit;

namespace Mapper.Tests
{
    public class MapperShould
    {
        private readonly DogMapper DogMapper;
        private readonly Dog Dog;

        public MapperShould()
        {
            DogMapper = new DogMapper();
            Dog = new Dog { Name = "Dog" };
        }

        [Fact]
        public void IsTypeOfMapper() => Assert.IsAssignableFrom<IMapper<Dog, SecondDog>>(DogMapper);

        [Fact]
        public void NameMapped()
        {
            var secondAsyncdog = DogMapper.Map(Dog);

            Assert.Equal(Dog.Name, secondAsyncdog.Name);
        }
    }
}
