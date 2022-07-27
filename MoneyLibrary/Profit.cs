namespace MoneyLibrary
{
    class Profit : IProfit
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Amount { get; }

        public Profit(string name, string description, decimal amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        public Profit CopyWithDifferentName(string newName)
        {
            return new Profit(newName, Description, Amount);
        }
    }
}