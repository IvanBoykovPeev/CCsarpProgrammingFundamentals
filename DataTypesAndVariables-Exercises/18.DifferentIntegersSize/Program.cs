using System;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            try
            {
                Console.WriteLine("{0} can fit in:", number);
                sbyte resutSbyte = sbyte.Parse(number);
                Console.WriteLine("* sbyte");
            }
            catch (Exception)
            {
            }
            try
            {
                byte resutByte = byte.Parse(number);
                Console.WriteLine("* byte");
            }
            catch (Exception)
            {
            }
            try
            {
                short resutShort = short.Parse(number);
                Console.WriteLine("* short");
            }
            catch (Exception)
            {
            }
            try
            {
                ushort resutUshort = ushort.Parse(number);
                Console.WriteLine("* ushort");
            }
            catch (Exception)
            {
            }
            try
            {
                int resutInt = int.Parse(number);
                Console.WriteLine("* int");
            }
            catch (Exception)
            {
            }
            try
            {
                uint resutUint = uint.Parse(number);
                Console.WriteLine("* uint");
            }
            catch (Exception)
            {
            }
            try
            {
                long resutLong = long.Parse(number);
                Console.WriteLine("* long");
            }
            catch (Exception)
            {
                Console.WriteLine("can't fit in any type");
            }
        }
    }
}
}
