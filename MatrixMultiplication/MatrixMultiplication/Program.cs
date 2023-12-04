internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int rows;
        int columns;
        int[,] matrixOne;
        int[,] matrixTwo;
        int[,] answerMatrix;

        //Set variables
        (rows, columns) = MatrixDimensions(1, 1);
        matrixOne = FillMatrix(1, rows, columns);
        (rows, columns) = MatrixDimensions(2, columns);
        matrixTwo = FillMatrix(2, rows, columns);

        //Multiply and output
        Console.Clear();
        answerMatrix = MatrixMultiplier(matrixOne, matrixTwo);
        for (int i = 0; i < answerMatrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < answerMatrix.GetLength(1); j++)
            {
                Console.Write($"{answerMatrix[i, j]} ");
            }
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

    private static int[,] FillMatrix(int matrixNumber, int rows, int columns)
    {
        //Declare and initialise variables
        int[,] matrix = new int[rows, columns];

        //Set variables
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = InputValidator($"Please enter the value for row {i + 1}, column {j + 1} of matrix {matrixNumber}: ");
            }
        }

        //Return
        return matrix;
    }

    private static int[,] MatrixMultiplier(int[,] matrixOne, int[,] matrixTwo)
    {
        //Declare and initialize variables
        int[,] answerMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

        //Multiply
        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                for (int k = 0; k < matrixOne.GetLength(1); k++)
                {
                    answerMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                }
            }
        }

        //Return
        return answerMatrix;
    }
}