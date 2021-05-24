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
            string choice = "";
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

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Would you like to continue? input Y to go again, input N to exit program");
                choice = Console.ReadLine();
                if(choice == "y" || choice == "Y"){
                    loopCondition = false;
                    Console.ResetColor();
                }
                else{
                    loopCondition = true;
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Indication the loop was successfully broken");
        }
    }
}
