using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            int recLength = int.Parse(length);

            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            int recWidth = int.Parse(width);

            Console.WriteLine($"The area of the rectangle is {recLength * recWidth}.");
        }
    }
}
