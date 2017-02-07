using System;
using System.Collections.Generic;

namespace _02.AppendLists
{
    class Program
    {
        static void Main()
        {
            var lists = Console.ReadLine().Split('|');
            var result = new List<string>();
            for (int i = lists.Length - 1; i >= 0 ; i--)
            {
                var list = lists[i].Split(' ');
                foreach (var item in list)
                {
                    if (item != string.Empty)
                    {
                    result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
