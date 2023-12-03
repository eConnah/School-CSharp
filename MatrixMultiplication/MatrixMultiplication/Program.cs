internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int rows;
        int columns;
        int[,] matrixOne;
        int[,] matrixTwo;

        //Set variables
        (rows, columns) = MatrixDimensions(1, 1);
        matrixOne = FillMatrix(rows, columns);
        (rows, columns) = MatrixDimensions(2, columns);
        matrixTwo = FillMatrix(rows, columns);
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

    private static (int, int) MatrixDimensions(int matrixNumber, int matrixOneC)
    {
        //Declare variables
        int rows;
        int columns;

        //Set variables
        do
        {
            rows = InputValidator($"Please enter the number of rows for matrix {matrixNumber}: ");
            if (rows < matrixOneC)
            {
                Console.Clear();
                Console.WriteLine("This is not possible. Try again.");
                Console.ReadKey();
            }
            else
            {
                break;
            }
        } while (true);
        do
        {
            columns = InputValidator($"Please enter the number of columns for matrix {matrixNumber}: ");
            if (columns < 1)
            {
                Console.Clear();
                Console.WriteLine("This is not possible. Try again.");
                Console.ReadKey();
            }
            else
            {
                break;
            }
        } while (true);

        //Return
        return (rows, columns);
    }

    private static int[,] FillMatrix(int rows, int columns)
    {
        //Declare and initialise variables
        int[,] matrix = new int[columns, rows];

        //Set variables
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[j, i] = InputValidator($"Please enter the value for row {i + 1}, column {j + 1}: ");
            }
        }

        //Return
        return matrix;
    }
}