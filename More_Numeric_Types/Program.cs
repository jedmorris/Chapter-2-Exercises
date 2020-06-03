using System;

namespace More_Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string miles = Console.ReadLine();
            int milesDriven = int.Parse(miles);

            Console.WriteLine("How many gallons of gas have you consumed?");
            string gas = Console.ReadLine();
            int gasConsumed = int.Parse(gas);

            Console.WriteLine($"Your current gas mileage is {milesDriven / gasConsumed}mpg.");
        }
    }
}
