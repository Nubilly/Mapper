using Mapper.Tests.Models;
using System.Diagnostics.CodeAnalysis;

namespace Mapper.Tests.Mappers
{
    public class DogMapper : IMapper<Dog, SecondDog>
    {
        [return: NotNull]
        public SecondDog Map([NotNull] Dog source1)
        {
            return new SecondDog { Name = source1.Name };
        }
    }
}
