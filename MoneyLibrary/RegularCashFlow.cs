using System.Diagnostics.CodeAnalysis;

namespace MoneyLibrary
{
    public class RegularCashFlow : CashFlow, IRegularCashFlow
    {
        public RegularCashFlow(string name, string description, decimal amount, IRegular regularity) : base(name, description, amount)
        {
            Regularity = regularity;
        }

        public RegularCashFlow(decimal amount, IRegular regularity) : base(amount)
        {
            Regularity = regularity;
        }
        
        public IRegular Regularity { get; private set; }
    }
}