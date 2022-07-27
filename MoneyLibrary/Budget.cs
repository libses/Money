using System;

namespace MoneyLibrary
{
    public class Budget : IBudget
    {
        public decimal MoneyAmount { get; private set; }
        public decimal DebtAmount { get; private set; }
    }
}