using System;

namespace HomeWork1
{
    class Program1
    {
        static void Main(string[] args)
        {
            string s = "";
            int number1 = 0;
            int number2 = 0;
            Console.WriteLine("\nPlease input the first number: ");
            s = Console.ReadLine();
            number1 = Int32.Parse(s);
            Console.WriteLine("\nPlease input the second number: ");
            s = Console.ReadLine();
            number2 = Int32.Parse(s);
            Console.WriteLine($"\nThe totall of the numbers is {number1+number2}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
    
}
