# Mapper

This is a simple mapper of objects, with no magic, to provide an alternative to the Extension mapping. 

To create a Mapper, just Inherit from the `IMapper<>` or `IMapperAsync<>`, if you need do to asynronous calls within the mapper,  
``` cs
using Mapper;

    public class DogMapper : IMapper<Dog, SecondDog>
    {
        [return: NotNull]
        public SecondDog Map([NotNull] Dog source1)
        {
            return new SecondDog { Name = source1.Name };
        }
    }
    
```

OR
``` cs
using Mapper;

    public class DogAsyncMapper : IMapperAsync<Dog, SecondDog>
    {
        [return: NotNull]
        public  async Task<SecondDog> MapAsync([NotNull] Dog source1, CancellationToken cancellationToken = default)
        {
            return await Task.Run(() => { return new SecondDog { Name = source1.Name }; }, cancellationToken);
        }
    }
```

Then its just a matter of call newing up your mapper and then calling `Map()`

``` cs
  new DogMapper().Map(new Dog { Name = "Woof" });
```

it can also be used the dependancy injection. this will scan for any class inhertiting from `IMapper<>` or `IMapperAsync<>` and register them as transient to the sevice collection
``` cs
using Mapper.Extensions.AspNetCore;

 var serviceProvider = new ServiceCollection()
                .AddMapper()
                .BuildServiceProvider();
```
Inject the IMapperFactory into your class and then specify the types you want to map.
``` cs
 var mapperFactory = serviceProvider.GetRequiredService<IMapperFactory>();

 var secondDog = mapperFactory.Map<Dog, SecondDog>(new Dog { Name = "Woof" });
                
```
you can also map collections
``` cs
 IEnumerable<SecondDog> secondDogList = mapperFactory.MapAll<Dog, SecondDog>(new Dog[3] { new Dog { Name = "Woof" }, new Dog { Name = "Woof" }, new Dog { Name = "Woof" } });
```


