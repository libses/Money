using System;

namespace MoneyLibrary
{
    public interface IRegular
    {
        DateTime GetNextTime();

        DateTime GetNextTime(DateTime now);
    }
}