using System;
namespace HW_09
{
    public class TimeCalculator
    {
        public DateTime date = new DateTime(2000, 1, 1, 0, 0, 0);

        public DateTime AddHours(double hours)
        {
            return date.AddHours(hours);
        }
    }
}
