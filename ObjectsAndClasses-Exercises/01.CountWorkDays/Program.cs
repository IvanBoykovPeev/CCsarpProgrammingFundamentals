using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01.CountWorkDays
{
    class Program
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26)
            };
            int workingDaysCounter = 0;
            for (DateTime currentDay = startDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                DateTime date = new DateTime(2016, currentDay.Month, currentDay.Day);
                if (!holidays.Contains(date) && currentDay.DayOfWeek != DayOfWeek.Saturday && currentDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
