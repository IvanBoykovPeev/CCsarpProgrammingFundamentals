using System;
using System.Linq;

namespace _6.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine("{0} => {1}", item, Math.Round(item, MidpointRounding.AwayFromZero));
            }
        }
    }
}
