namespace MoneyLibrary
{
    public interface ICashFlow
    {
        string Name { get; }
        string Description { get; }
        decimal Amount { get; }
    }
}