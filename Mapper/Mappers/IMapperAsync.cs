using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Mapper
{
    public interface IMapperAsync<in TSource1, TTarget>
        where TSource1 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, TTarget>
        where TSource1 : notnull where TSource2 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, in TSource9, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, CancellationToken cancellationToken = default);
    }

    public interface IMapperAsync<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, in TSource9, in TSource10, TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull
    {
        [return: NotNull]
        Task<TTarget> MapAsync([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10, CancellationToken cancellationToken = default);
    }
}
