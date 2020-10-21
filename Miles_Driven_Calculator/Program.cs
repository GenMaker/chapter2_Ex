using System;

namespace Miles_Driven_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles per gallon does your car get?");
            double milesPerGallon = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many miles did you drive?");
            double milesDriven = Convert.ToInt32(Console.ReadLine());

            double gasUsed = milesDriven / milesPerGallon;
            Console.WriteLine("You have used " + gasUsed + " gallons of gas.");

            Console.WriteLine("this line is here to pause my console display");


        }
    }
}
