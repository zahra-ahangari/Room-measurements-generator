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
            double area;
            double perimeter;
            double volume;
            string choice = "";
            Boolean loopCondition = false;

            Console.WriteLine("Welcome to the room generator. Our measurements will be in inches.");

            // While loop will keep looping until condition is set to true
            while (loopCondition != true)
            {
                // Measurements are inputed. The area, perimeter, and volume are calculated
                Console.WriteLine("Please enter your length");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your Width");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your height");
                height = Convert.ToDouble(Console.ReadLine());

                area = length * width;
                perimeter = (length * 2) + (width * 2);
                volume = length * width * height;

                Console.WriteLine("The area of your room is: " + area);
                Console.WriteLine("The perimeter of your room is: " + perimeter);
                Console.WriteLine("The volume of your room is: " + volume);

                // User is prompt to go through sequence again, otherwise program is terminated.
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

            Console.WriteLine("Thank you for playing, goodbye!");
        }
    }
}
