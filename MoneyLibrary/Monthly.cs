using System;

namespace MoneyLibrary
{
    public class Monthly : IPatternRegular
    {
        public Monthly(int dayOfMonth)
        {
            if (dayOfMonth > 28)
            {
                throw new ArgumentException("February have 28 days");
            }
            
            DayOfMonth = dayOfMonth;
        }

        public int DayOfMonth { get; }
        
        public DateTime GetNextTime()
        {
            return GetNextTime(DateTime.Now);
        }
        
        public DateTime GetNextTime(DateTime now)
        {
            if (now.Day >= DayOfMonth)
            {
                var month = now.Month + 1;
                var year = month > 12 ? now.Year + 1 : now.Year;
                month = month > 12 ? month - 12 : month;
                return new DateTime(year, month, DayOfMonth);
            }

            return new DateTime(now.Year, now.Month, DayOfMonth);
        }
    }
}