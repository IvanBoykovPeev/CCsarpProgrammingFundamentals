using System;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (input > 0 && input <= 7)
            {
                Console.WriteLine(days[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
