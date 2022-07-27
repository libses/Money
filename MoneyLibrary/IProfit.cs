namespace MoneyLibrary
{
    public interface IProfit
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Amount { get; }
    }
}