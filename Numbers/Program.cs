using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            int recatangleLength = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the retangle?");
            int rectangleWidth = int.Parse(Console.ReadLine());

            int rectangleArea = recatangleLength * rectangleWidth;

            Console.WriteLine("The area of your rectangle is: " + rectangleArea);

        }
    }
}
