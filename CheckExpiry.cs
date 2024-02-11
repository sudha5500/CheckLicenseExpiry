using System;

namespace CalculateExpiry
{
    public class CheckExpiry
    {
        public DateTime CalculateExpiryDate(DateTime boughtDate)
        {
            DateTime expiryDate = new DateTime();
            if (boughtDate.Day <= 10)
            {
                // end of the month 
                var startOfMonth = new DateTime(boughtDate.Year, boughtDate.Month, 1);
                var DaysInMonth = DateTime.DaysInMonth(boughtDate.Year, boughtDate.Month);
                expiryDate = new DateTime(boughtDate.Year, boughtDate.Month, DaysInMonth);
            }
            else if (boughtDate.Day > 10 && boughtDate.Day <= 20)
            {
                // end of the month + 10 days
                var startOfMonth = new DateTime(boughtDate.Year, boughtDate.Month, 1);
                //var DaysInMonth = DateTime.DaysInMonth(boughtDate.Year, boughtDate.Month);
                expiryDate = new DateTime(boughtDate.Year, boughtDate.Month+1, 0 + 10);
            }
            else if (boughtDate.Day >= 21)
            {
                // last day of the next month
                var startOfMonth = new DateTime(boughtDate.Year, boughtDate.Month, 1);
                var DaysInMonth = DateTime.DaysInMonth(boughtDate.Year, boughtDate.Month+1);
                expiryDate = new DateTime(boughtDate.Year, boughtDate.Month + 1, DaysInMonth);

            }
            return expiryDate.Date;

        }
    }
}