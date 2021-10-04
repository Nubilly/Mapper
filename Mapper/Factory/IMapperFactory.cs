using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Mapper
{
    public interface IMapperFactory
    {
        [return: NotNull]
        TTarget Map<TSource1, TTarget>([NotNull] TSource1 source1)
            where TSource1 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2)
            where TSource1 : notnull where TSource2 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull;
        
        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull;

        [return: NotNull]
        TTarget Map<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TTarget>([NotNull] TSource1 source1, CancellationToken cancellationToken = default)
            where TSource1 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull;
        
        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull;

        [return: NotNull]
        Task<TTarget> MapAsync<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TTarget>([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10, CancellationToken cancellationToken = default)
            where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull;
    }
}

