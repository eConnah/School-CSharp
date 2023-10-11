internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int[] numbers;
        int[] sortedNumbers;

        //Set variables
        numbers = new int[] { 19, 5, 0, -1, 10, -5 };

        //Output
        Console.WriteLine("Here is the array before sorting: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        //Sort
        sortedNumbers = Sorted(numbers);

        //Output
        Console.WriteLine("Here is the array after sorting: ");
        foreach (int sortedNumber in sortedNumbers)
        {
            Console.Write($"{sortedNumber} ");
        }
        Console.WriteLine();
    }

    private static int[] Sorted(int[] numbers)
    {
        //Declare variables
        int tempNumOne;
        int tempNumTwo;
        int sorted;

        //Set variable
        sorted = -1;

        //Loop
        while (sorted != 0)
        {
            sorted = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (i < numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        tempNumOne = numbers[i];
                        tempNumTwo = numbers[i + 1];
                        numbers[i] = tempNumTwo;
                        numbers[i + 1] = tempNumOne;
                        sorted++;
                    }
                }
            }
        }


        //Output
        return numbers;
    }
}