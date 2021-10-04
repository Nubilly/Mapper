using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mapper
{
    public static class MapperFactoryExtensions
    {
        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1)
            where TSource1 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TTarget>(x));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2)
            where TSource1 : notnull where TSource2 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TTarget>(x, source2));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TTarget>(x, source2, source3));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TTarget>(x, source2, source3, source4));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>(x, source2, source3, source4, source5));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>(x, source2, source3, source4, source5, source6));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>(x, source2, source3, source4, source5, source6, source7));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>(x, source2, source3, source4, source5, source6, source7, source8));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>(x, source2, source3, source4, source5, source6, source7, source8, source9));
        }

        [return: NotNull]
        public static IEnumerable<TTarget> MapAll<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull
        {
            return source1.Select(x => mapperFactory.Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>(x, source2, source3, source4, source5, source6, source7, source8, source9, source10));
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, CancellationToken cancellationToken = default)
             where TSource1 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TTarget>(x, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, CancellationToken cancellationToken = default)
             where TSource1 : notnull where TSource2 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TTarget>(x, source2, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, CancellationToken cancellationToken = default)
             where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TTarget>(x, source2, source3, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, CancellationToken cancellationToken = default)
             where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TTarget>(x, source2, source3, source4, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>(x, source2, source3, source4, source5, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>(x, source2, source3, source4, source5, source6, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>(x, source2, source3, source4, source5, source6, source7, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>(x, source2, source3, source4, source5, source6, source7, source8, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>(x, source2, source3, source4, source5, source6, source7, source8, source9, cancellationToken)));

            return tasks.AsEnumerable();
        }

        [return: NotNull]
        public static async Task<IEnumerable<TTarget>> MapAllAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>([NotNull] this IMapperFactory mapperFactory, [NotNull] IEnumerable<TSource1> source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull
        {
            var tasks = await Task.WhenAll(source1.Select(x => mapperFactory.MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>(x, source2, source3, source4, source5, source6, source7, source8, source9, source10, cancellationToken)));

            return tasks.AsEnumerable();
        }
    }
}
