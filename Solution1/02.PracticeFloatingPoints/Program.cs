using System;

namespace _02.PracticeFloatingPoints
{
    class Program
    {
        static void Main()
        {
            decimal num1 = 3.141592653589793238m;
            decimal num2 = 1.60217657m;
            decimal num3 = 7.8184261974584555216535342341m;

            Console.WriteLine("{0:f18}", num1);
            Console.WriteLine("{0:f8}", num2);
            Console.WriteLine("{0:f28}", num3);
        }
    }
}
