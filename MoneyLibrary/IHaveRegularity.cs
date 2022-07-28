using System.Diagnostics.CodeAnalysis;

namespace MoneyLibrary
{
    public interface IHaveRegularity
    {
        [NotNull]
        IRegular Regularity { get; }
    }
}