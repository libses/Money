using System;
using FluentAssertions;
using MoneyLibrary;
using NUnit.Framework;

namespace MoneyTests
{
    public class RepositoryTests
    {
        public Repository Repository;

        [SetUp]
        public void SetUp()
        {
            Repository = new Repository();
            Repository.SetMoneyAmount(10000);
        }
        
        [TestCase(2007, 9, 8, 12, 11, 11, 10, 5000, Description = "Ordinary")]
        [TestCase(2007, 12, 31, 11, 11, 11, 1, 10000, Description = "New year")]
        public void GetDailyBudgetOrdinaryMonthly(int year, int month, int day,
            int hour, int minute, int second,
            int dayOfMonth,
            int expected)
        {
            var today = new DateTime(year, month, day, hour, minute, second);
            Repository.AddRegularCashFlow(new RegularCashFlow(10000, new Monthly(dayOfMonth)));
            Repository.GetDailyBudgetToNextRegular(today).Should().Be(expected);
        }
    }
}