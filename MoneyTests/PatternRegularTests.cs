using System;
using MoneyLibrary;
using NUnit.Framework;

namespace MoneyTests
{
    public class PatternRegularTests
    {
        [Test]
        public void GivingThisMonthDayWhenDayIsInFuture()
        {
            var now = DateTime.Now;
            var monthly = new Monthly(15);
            
        }
    }
}