using System.Threading;
using System.Threading.Tasks;

namespace Mapper.Test
{
    public class TestMapper : IMapper<Dog, SecondDog>
    {
        public SecondDog Map(Dog source1)
        {
            return new SecondDog { Name = source1.Name };
        }
    }

    public class TestAsyncMapper : IMapperAsync<Dog, SecondDog>
    {
        public async Task<SecondDog> MapAsync(Dog source1, CancellationToken cancellationToken)
        {
            return await Task.Run(() => { return new SecondDog { Name = source1.Name }; }, cancellationToken);            
        }
    }
}
