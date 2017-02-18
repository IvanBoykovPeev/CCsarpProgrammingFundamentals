using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            float dictanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeInSeconds = ((hours * 60.0f) + minutes) * 60.0f + seconds;
            float metersPerSekonds = dictanceInMeters / timeInSeconds;
            float kilometersPerHours = (dictanceInMeters / 1000.0f) / (timeInSeconds / 3600.0f);
            float metersPerHours = (dictanceInMeters / 1609.0f) / (timeInSeconds / 3600.0f);
            Console.WriteLine(metersPerSekonds);
            Console.WriteLine(kilometersPerHours);
            Console.WriteLine(metersPerHours);
        }
    }
}
