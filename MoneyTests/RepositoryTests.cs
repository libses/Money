using System;
using FluentAssertions;
using MoneyLibrary;
using NUnit.Framework;

namespace MoneyTests
{
    public class RepositoryTests
    {
        [Test]
        public void OrdinaryCaseMustReturnCorrect()
        {
            var repo = new Repository();
            repo.SetMoneyAmount(10000);
            var today = new DateTime(2007, 9, 8, 12, 11, 11);
            repo.AddRegularCashFlow(new RegularCashFlow(10000, new Monthly(10)));
            repo.GetDailyBudgetToNextRegular(today).Should().Be(5000);
        }
    }
}