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

        //Fill board
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (printWhite)
                {
                    board[i, j] = "\u2588\u2588\u2588";
                    printWhite = false;
                }
                else
                {
                    board[i, j] = "   ";
                    printWhite = true;
                }
            }
            if (width % 2 == 0)
            {
                printWhite = !printWhite;
            }
        }

        //Print
        Console.Clear();
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(board[i, j]);
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