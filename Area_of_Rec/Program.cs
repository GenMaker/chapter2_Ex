using System;

namespace Area_of_Rec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle.");
            string length = Console.ReadLine();

            Console.WriteLine("Enter the width.");
            string width = Console.ReadLine();

            int convertedLength = int.Parse(length);
            int convertedwidth = int.Parse(width);
            int area = convertedLength * convertedwidth;

            Console.WriteLine("The area of your rectangle is " + area);

            Console.WriteLine("this line is here to pause my console display");

        }
    }
}
