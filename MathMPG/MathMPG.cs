using System;

namespace MathMPG
{
    class MathMPG
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How much gas, in gallons, have you used?");
            int gas = int.Parse(Console.ReadLine());

            int mpg = miles / gas;
            Console.WriteLine("You are averaging " + mpg + " miles per gallon.");
        }
    }
}
