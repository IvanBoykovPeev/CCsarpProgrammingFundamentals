using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main()
        {
            DateTime leavesUni = new DateTime();
            long numberOfSteps = 0;
            long timeInSeconds = 0;
            leavesUni = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.CurrentCulture);
                numberOfSteps = long.Parse(Console.ReadLine());
                timeInSeconds = long.Parse(Console.ReadLine());
            long seconds = timeInSeconds * numberOfSteps;
            DateTime timeOfArrival;
            if (seconds >= 0)
            {
            timeOfArrival = leavesUni.AddSeconds(seconds);
            }
            else
            {
            timeOfArrival = leavesUni.AddSeconds(0);
            }

            Console.WriteLine("Time Arrival: {0}",timeOfArrival.ToString("HH:mm:ss", CultureInfo.CurrentCulture));
        }
    }
}
