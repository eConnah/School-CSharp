internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int length;
        int width;
        string[,] board;
        bool printWhite = true;

        //Set variables
        length = InputValidator("Please enter the length of the board: ");
        width = InputValidator("Please enter the width of the board: ");
        board = new string[length, width];

        //Print board
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (printWhite)
                {
                    Console.Write("\u2588");
                    Console.Write("\u2588");
                    Console.Write("\u2588");
                    printWhite = false;
                }
                else
                {
                    Console.Write("   ");
                    printWhite = true;
                }
            }
            Console.WriteLine();
            printWhite = !printWhite;
        }
    }

    private static int InputValidator(string prompt)
    {
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
}