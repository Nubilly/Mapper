using System.Diagnostics.CodeAnalysis;

namespace Mapper
{
    public interface IMapper<in TSource1, out TTarget>
        where TSource1 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1);
    }

    public interface IMapper<in TSource1, in TSource2, out TTarget>
        where TSource1 : notnull where TSource2 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, in TSource9, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9);
    }

    public interface IMapper<in TSource1, in TSource2, in TSource3, in TSource4, in TSource5, in TSource6, in TSource7, in TSource8, in TSource9, in TSource10, out TTarget>
        where TSource1 : notnull where TSource2 : notnull where TSource3 : notnull where TSource4 : notnull where TSource5 : notnull where TSource6 : notnull where TSource7 : notnull where TSource8 : notnull where TSource9 : notnull where TSource10 : notnull
    {
        [return: NotNull]
        TTarget Map([NotNull] TSource1 source1, [NotNull] TSource2 source2, [NotNull] TSource3 source3, [NotNull] TSource4 source4, [NotNull] TSource5 source5, [NotNull] TSource6 source6, [NotNull] TSource7 source7, [NotNull] TSource8 source8, [NotNull] TSource9 source9, [NotNull] TSource10 source10);
    }
}
