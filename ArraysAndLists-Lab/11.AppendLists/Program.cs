using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.AppendLists
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();
            input.Reverse();
            foreach (var item in input)
            {
                List<string> list = item.Split().ToList();
                foreach (var num in list)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));            
        }
    }
}
