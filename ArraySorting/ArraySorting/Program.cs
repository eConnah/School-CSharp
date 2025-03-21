﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int arrayLength;
        int[] intArray;

        //Set variables
        do
        {
            arrayLength = InputValidator("Please enter the length of the array you would like (must be above 0): ");
        } while (arrayLength < 1);
        intArray = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            intArray[i] = InputValidator($"Enter number {i + 1}: ");
        }

        //Print
        Console.Clear();
        Console.Write($"The unsorted array is: ");
        foreach (int item in intArray)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Console.Write($"The sorted array is: ");
        foreach (int item in BubbleSort(intArray))
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    private static int InputValidator(string prompt)
    {
        //Set variables
        Console.Clear();
        do
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("An invalid input has been entered.");
            }
        } while (true);
    }

    private static int[] BubbleSort(int[] inputArray)
    {
        //Declare variables
        bool passed;

        //Sort
        do
        {
            passed = false;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] > inputArray[i + 1])
                {
                    (inputArray[i], inputArray[i + 1]) = (inputArray[i + 1], inputArray[i]);
                    passed = true;
                }
            }
        } while (passed);

        //Return
        return inputArray;
    }
}