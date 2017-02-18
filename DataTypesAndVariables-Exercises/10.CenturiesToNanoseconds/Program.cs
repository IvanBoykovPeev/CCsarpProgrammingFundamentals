﻿using System;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            uint centuries = uint.Parse(Console.ReadLine());

            uint years = centuries * 100;
            BigInteger days = (BigInteger)(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}