using System;
using System.Globalization;
using FluentAssertions;
using MoneyLibrary;
using NUnit.Framework;

namespace MoneyTests
{
    public class PatternRegularTests
    {
        [Test]
        public void GivingThisMonthDayWhenOrdinaryDayIsInFuture()
        {
            var now = new DateTime(2007, 9, 15);
            var monthly = new Monthly(16);
            monthly.GetNextTime(now).Should().Be(new DateTime(2007, 9, 16));
        }
        
        [Test]
        public void GivingNextMonthDayWhenOrdinaryDayIsInPast()
        {
            var now = new DateTime(2007, 9, 15);
            var monthly = new Monthly(14);
            monthly.GetNextTime(now).Should().Be(new DateTime(2007, 10, 14));
        }
        
        [Test]
        public void GivingNextYearDayWhenNewYear()
        {
            var now = new DateTime(2007, 12, 15);
            var monthly = new Monthly(14);
            monthly.GetNextTime(now).Should().Be(new DateTime(2008, 1, 14));
        }

        [Test]
        public void ThrowingWhenDayIsMoreThan28()
        {
            Action action = () =>
            {
                var monthly = new Monthly(31);
            };

            action.Should().Throw<ArgumentException>();
        }
    }
}