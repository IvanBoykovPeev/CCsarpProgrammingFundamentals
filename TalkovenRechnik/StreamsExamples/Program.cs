using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create streamReader to conected to a file 
            StreamReader reader = new StreamReader("..\\..\\Test.txt");

            string line = reader.ReadLine();


            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
