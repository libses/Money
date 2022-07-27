using System;

namespace MoneyLibrary
{
    public class Monthly : IPatternRegular
    {
        public Monthly(int dayOfMonth)
        {
            if (dayOfMonth > 28)
            {
                throw new ArgumentException("В феврале иногда 28 дней");
            }
            
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