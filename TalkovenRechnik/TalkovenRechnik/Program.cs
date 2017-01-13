using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkovenRechnik
{
    class Program
    {
        static void Main()
        {
            string command = string.Empty;
            while (command != "exit")
            {
                List<string> input = new List<string>();
                StreamReader reader = new StreamReader(@"C:\Users\blade\Desktop\source\TalkovenRechnik\StreamsExamples\Test.txt", Encoding.Default);
                Dictionary<string, string> words = new Dictionary<string, string>();
                int index;
                string line = reader.ReadLine();

                while (line != null)
                {
                    input.Add(line);
                    line = reader.ReadLine();
                }

                for (int i = 0; i < input.Count; i++)
                {
                    index = input[i].IndexOf("-");
                    if (!words.ContainsKey(input[i].Substring(0, index - 1)))
                    {
                        words.Add(input[i].Substring(0, index - 1), input[i].Substring(index + 2));
                    }
                }
                reader.Close();

                foreach (var item in words)
                {
                    Console.WriteLine(item);
                }

                string wordForSearch = Console.ReadLine();
                if (words.ContainsKey(wordForSearch))
                {
                    Console.WriteLine(words[wordForSearch]);
                }
                else
                {
                    Console.WriteLine("word is not defined");
                }
                Console.WriteLine("for stop write exit");
                command = Console.ReadLine();
            }
        }
    }
}
