using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            decimal numOne;
            decimal numTwo;
            string Op;

            //Set variables
            Console.WriteLine("Please enter your first number: ");
            numOne = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            numTwo = Convert.ToDecimal(Console.ReadLine());
            Op = Operator("What operator would you like to use; Divide, Multiply, Subtract or Add: ");
            switch (Op)
            {
                case "Divide":
                    Console.WriteLine(numOne / numTwo);
                    break;
                case "Multiply":
                    Console.WriteLine(numOne * numTwo);
                    break;
                case "Subtract":
                    Console.WriteLine(numOne - numTwo);
                    break;
                case "Add":
                    Console.WriteLine(numOne + numTwo);
                    break;
                default:
                    break;
            }
        }

        static string Operator(string prompt)
        {

            string inputOp;

            do
            {
                Console.WriteLine(prompt);
                inputOp = Console.ReadLine()?.Trim() ?? String.Empty;
                if (inputOp != "Divide" & inputOp != "Multiply" & inputOp != "Subtract" & inputOp != "Add")
                {
                    Console.WriteLine("Please enter a valid operator.");
                }
                else
                {
                    break;
                }
            } while (true);
            return inputOp;
        }
    }
}