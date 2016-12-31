using System;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            var PersonalID = long.Parse(Console.ReadLine());
            var employeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", PersonalID);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
