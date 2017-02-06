using System;

namespace _16.InstructionSet
{
    class Program
    {
        static void Main()
        {            
            string opCode = Console.ReadLine();           
            
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                opCode = Console.ReadLine();
                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            result = long.Parse(codeArgs[1]) + 1;
                            break;
                        }
                    case "DEC":
                        {
                            result = long.Parse(codeArgs[1]) - 1;
                            break;
                        }
                    case "ADD":
                        {
                            result = long.Parse(codeArgs[1]) + long.Parse(codeArgs[2]);
                            break;
                        }
                    case "MLA":
                        {
                            result = long.Parse(codeArgs[1]) * long.Parse(codeArgs[2]);
                            break;
                        }                        
                }
                Console.WriteLine(result);
            }            
        }
    }
}
