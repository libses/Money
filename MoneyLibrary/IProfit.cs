namespace MoneyLibrary
{
    public interface IProfit
    {
        string Name { get; }
        string Description { get; }
        decimal Amount { get; }
    }
}