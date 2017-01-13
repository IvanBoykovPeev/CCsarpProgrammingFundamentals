using System;
using System.Collections.Generic;

namespace Ch04_Lists
{
    class Program
    {
        static void Main()
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            Console.WriteLine("Initial list");
            foreach (var citi in cities)
            {
                Console.WriteLine($"  {citi}");
            }
            cities.RemoveAt(1);
            cities.Remove("Milan");
            Console.WriteLine("After removing two cities");
            foreach (var citi in cities)
            {
                Console.WriteLine($"  {citi}");
            }
        }
    }
}
