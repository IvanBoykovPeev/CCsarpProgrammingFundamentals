using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main()
        {
            char simbol = char.Parse(Console.ReadLine());
            if (char.IsDigit(simbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                switch (simbol)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'i':
                    case 'u':
                    case 'y': Console.WriteLine("vowel"); break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }
        }
    }
}
