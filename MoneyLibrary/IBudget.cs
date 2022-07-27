namespace MoneyLibrary
{
    public interface IBudget
    {
        decimal MoneyAmount { get; }
        decimal DebtAmount { get; }
    }
}