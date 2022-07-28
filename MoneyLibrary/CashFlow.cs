using System.Diagnostics.CodeAnalysis;

namespace MoneyLibrary
{
    public class CashFlow : ICashFlow
    {
        [NotNull]
        public string Name { get; }
        [NotNull]
        public string Description { get; }
        public decimal Amount { get; }

        public CashFlow(string name, string description, decimal amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        public CashFlow(decimal amount)
        {
            Name = "";
            Description = "";
            Amount = amount;
        }

        public CashFlow CopyWithDifferentName(string newName)
        {
            return new CashFlow(newName, Description, Amount);
        }
    }
}