internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initialise variables
        int numOfDice;
        Random rolledNum = new();

        //Set variables
        numOfDice = InputValidator("How many dice would you like to roll? ");

        //Print
        Console.Clear();
        for (int i = 0; i < numOfDice; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("\rDice " + (i + 1) + ": " + rolledNum.Next(1, 7));
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }
    }

    private static int InputValidator(string prompt)
    {
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number < 1)
                {
                    Console.Clear();
                    Console.WriteLine("The number must be greater than 0.");
                }
                else
                {
                    return number;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("An invalid input has been entered.");
            }
        }
    }
}