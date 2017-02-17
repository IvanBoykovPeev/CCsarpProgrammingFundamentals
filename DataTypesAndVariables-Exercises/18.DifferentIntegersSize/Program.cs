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
                sbyte resutSbyte = sbyte.Parse(number);
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine("* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long");
            }
            catch (Exception)
            {
                try
                {
                    byte resutByte = byte.Parse(number);
                    Console.WriteLine("{0} can fit in:", number);
                    Console.WriteLine("* byte\n* short\n* ushort\n* int\n* uint\n* long");
                }
                catch (Exception)
                {
                    try
                    {
                        short resutShort = short.Parse(number);
                        Console.WriteLine("{0} can fit in:", number);
                        Console.WriteLine("* short\n* int\n* long");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            ushort resutUshort = ushort.Parse(number);
                            Console.WriteLine("{0} can fit in:", number);
                            Console.WriteLine("* ushort\n* int\n* uint\n* long");
                        }
                        catch (Exception)
                        {
                            try
                            {
                                int resutInt = int.Parse(number);
                                Console.WriteLine("{0} can fit in:", number);
                                Console.WriteLine("* int\n* uint\n* long");
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    uint resutUint = uint.Parse(number);
                                    Console.WriteLine("{0} can fit in:", number);
                                    Console.WriteLine("* uint\n* int\n* long");
                                }
                                catch (Exception)
                                {
                                    try
                                    {
                                        long resutLong = long.Parse(number);
                                        Console.WriteLine("{0} can fit in:", number);
                                        Console.WriteLine("* long");
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("{0} can't fit in any type", number);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
