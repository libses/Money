using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace MoneyLibrary
{
    public class Repository : IRepository
    {
        public Repository()
        {
        }

        public decimal MoneyAmount { get; private set; }
        
        public readonly List<IRegularCashFlow> RegularCashFlows = new List<IRegularCashFlow>();

        public readonly List<ICashFlow> CashFlows = new List<ICashFlow>();

        public void AddRegularCashFlow(IRegularCashFlow cashFlow)
        {
            RegularCashFlows.Add(cashFlow);
        }

        public void AddCashFlow(ICashFlow cashFlow)
        {
            CashFlows.Add(cashFlow);
        }

        public void SetMoneyAmount(decimal amount)
        {
            MoneyAmount = amount;
        }

        public decimal GetDailyBudgetToNextRegular()
        {
            return GetDailyBudgetToNextRegular(DateTime.Now);
        }
        
        public decimal GetDailyBudgetToNextRegular(DateTime now)
        {
            var nextDate = RegularCashFlows.Select(x => x.Regularity.GetNextTime(now)).Min();
            var delta = nextDate - now.Date;
            if (delta.Days != 0)
            {
                return MoneyAmount / delta.Days;
            }

            return MoneyAmount;
        }
    }
}