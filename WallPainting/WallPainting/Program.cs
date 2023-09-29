using System;

namespace WallPainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            double length;
            double width;
            double totalArea;
            double paintCost;
            bool validInput;
            string lengthInput;
            string widthInput;

            // Prompt the user for room dimensions and validate input
            validInput = false;
            do
            {
                Console.WriteLine("Enter the length of the room in meters: ");
                lengthInput = Console.ReadLine()?.Trim() ?? string.Empty;
                if (double.TryParse(lengthInput, out length) & length != 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput );

            validInput = false;
            do
            {
                Console.WriteLine("Enter the width of the room in meters: ");
                widthInput = Console.ReadLine()?.Trim() ?? string.Empty;
                if (double.TryParse(widthInput, out width) & width != 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);

            // Calculate the total area to be painted (in square meters)
            totalArea = length * width;

            // Calculate the total cost of painting
            paintCost = totalArea * 1.40;

            // Output the results
            Console.WriteLine($"Total area to be painted: {totalArea} square meters");
            Console.WriteLine($"Total cost of paint: £{paintCost:F2}");
        }
    }
}
