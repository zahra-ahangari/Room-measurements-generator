using System;

namespace Room_Detail_Generator
{
    class Room_Generator
    {
        static void Main(string[] args)
        {
            // initialize variables
            double length;
            double width;
            double height;
            string choice;
            Boolean loopCondition = false;

            Console.WriteLine("Welcome to the room generator. Our measurements will be in inches.");

            while (loopCondition != true)
            {

                Console.WriteLine("Please enter your length");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your Width");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your height");
                height = Convert.ToDouble(Console.ReadLine());

                loopCondition = true;
            }

            Console.WriteLine("Indication the loop was successfully broken");
        }
    }
}
