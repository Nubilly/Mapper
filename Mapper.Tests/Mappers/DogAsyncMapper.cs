using Mapper.Tests.Models;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Mapper.Tests.Mappers
{
    public class DogAsyncMapper : IMapperAsync<Dog, SecondDog>
    {
        [return: NotNull]
        public  async Task<SecondDog> MapAsync([NotNull] Dog source1, CancellationToken cancellationToken = default)
        {
            return await Task.Run(() => { return new SecondDog { Name = source1.Name }; }, cancellationToken);
        }
    }
}
