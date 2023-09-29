using System;

namespace NumberAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the Variables
            string userInput;
            int number;

            // Loop until valid input
            do {
                Console.WriteLine("Please enter a 3-digit number: ");
                userInput = Console.ReadLine()?.Trim() ?? String.Empty;;
                if (userInput.Length != 3) {
                    Console.WriteLine("Invalid input.");
                }
            } while (userInput.Length != 3);

            // Parse the input string into an integer
            number = int.Parse(userInput);

            // Extract hundreds, tens, and units
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            // Output the results
            Console.WriteLine($"Hundreds: {hundreds}");
            Console.WriteLine($"Tens: {tens}");
            Console.WriteLine($"Units: {units}");
        }
    }
}
