using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Mapper
{
    public static class MapperExtensions
    {
        private static IEnumerable<Type> ExportedTypes(Assembly assembly)
        {
            try
            {
                return assembly.ExportedTypes.ToList();
            }
            catch (ArgumentException)
            {
                // security, trust or access error loading assembly
            }
            return new List<Type>();
        }

        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var mappers = AppDomain.CurrentDomain.GetAssemblies().Where(x => !x.IsDynamic).SelectMany(x => ExportedTypes(x).Where(t => t.IsClass && !t.IsGenericTypeDefinition && t.GetInterfaces().Any(i => i.IsGenericType
                && (i.GetGenericTypeDefinition() == typeof(IMapper<,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,,,,,>)
                || i.GetGenericTypeDefinition() == typeof(IMapper<,,,,,,,,,,>))
            ))).ToList();

            foreach (var mapper in mappers)
            {
                services.TryAddTransient(mapper.GetInterfaces().First(), mapper);
            }

            var asyncMappers = AppDomain.CurrentDomain.GetAssemblies().Where(x => !x.IsDynamic).SelectMany(x => ExportedTypes(x).Where(t => t.IsClass && !t.IsGenericTypeDefinition && t.GetInterfaces().Any(i => i.IsGenericType
               && (i.GetGenericTypeDefinition() == typeof(IMapperAsync<,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,,,,,>)
               || i.GetGenericTypeDefinition() == typeof(IMapperAsync<,,,,,,,,,,>))
           ))).ToList();

            foreach (var asyncMapper in asyncMappers)
            {
                services.TryAddTransient(asyncMapper.GetInterfaces().First(), asyncMapper);
            }
            
            services.TryAddScoped<IMapperFactory, MapperFactory>();
            return services;
        }       
    }
}
