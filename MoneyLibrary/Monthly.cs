using System;

namespace MoneyLibrary
{
    public class Monthly : IPatternRegular
    {
        public Monthly(int dayOfMonth)
        {
            DayOfMonth = dayOfMonth;
        }

        public int DayOfMonth { get; }
        
        public DateTime GetNextTime()
        {
            var now = DateTime.Now;
            if (now.Day >= DayOfMonth)
            {
                var month = now.Month + 1;
                var year = month > 12 ? now.Year + 1 : now.Year;
                return new DateTime(year, month, DayOfMonth);
            }

            return new DateTime(now.Year, now.Month, DayOfMonth);
        }
    }
}