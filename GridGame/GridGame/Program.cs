internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char[,] gridArray;
        int oldRow;
        int targetRow;
        int targetColumn;
        int gridWidth;
        int gridLength;
        int x;
        int yOne;
        int yTwo;

        //Set variables
        gridArray = new char[,] {
            {'7','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'6','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'5','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'4','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'3','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'2','x','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {'1','O','x','x','x','x','x','x','x','x','x','x','x','x','x'},
            {' ','1','2','3','4','5','6','7','8','9','A','B','C','D','E'}
        };
        gridWidth = gridArray.GetLength(1);
        gridLength = gridArray.GetLength(0);
        x = yOne = yTwo = 1;

        //Output one
        Console.WriteLine("Here is the current grid. Use a distance of 1.");
        for (int length = 0; length < gridLength; length++)
        {
            for (int width = 0; width < gridWidth; width++)
            {
                Console.Write($"{gridArray[length, width]} ");
            }
            Console.WriteLine();
        }

        //Loop
        do
        {
            //Update grid
            (oldRow, targetRow, targetColumn) = Target(gridWidth, gridLength);
            if (Math.Pow((oldRow - yOne), 2) == 1 || Math.Pow((oldRow - yOne), 2) == 0)
            {
                yOne = oldRow;
                if (Math.Pow((targetColumn - x), 2) == 1 || Math.Pow((targetColumn - x), 2) == 0)
                {
                    yOne = AbsoluteRow(yTwo, gridLength);
                    gridArray[yOne, x] = 'x';
                    x = targetColumn;
                    gridArray[targetRow, targetColumn] = 'O';
                }
                else
                {
                    yOne = yTwo;
                }
            }

            //Output two
            Console.WriteLine("Here is the current grid. Use a distance of 1.");
            for (int length = 0; length < gridLength; length++)
            {
                for (int width = 0; width < gridWidth; width++)
                {
                    Console.Write($"{gridArray[length, width]} ");
                }
                Console.WriteLine();
            }
        } while (true);
    }
    private static (int, int, int) Target(int gridWidth, int gridLength)
    {
        //Declare variables
        int column;
        int row;
        int trueRow;
        string columnInputA;
        char columnInputB;

        //Dictionary for hex
        Dictionary<char, int> hexCoords = new()
        {
            {'A', 10},
            {'B', 11},
            {'C', 12},
            {'D', 13},
            {'E', 14}
        };

        //Set variables
        Console.Write("Which column would you like to update: ");
        while (!int.TryParse(columnInputA = Console.ReadLine()?.Trim().ToUpper() ?? string.Empty, out column) || column >= gridWidth || column <= 0)
        {
            columnInputB = Convert.ToChar(columnInputA);
            if (hexCoords.ContainsKey(columnInputB))
            {
                column = hexCoords[columnInputB];
                break;
            }
            Console.Write("Please enter a valid input: ");
        }
        Console.Write("Which row would you like to update: ");
        while (!int.TryParse(Console.ReadLine(), out row) || row >= gridLength || row <= 0)
        {
            Console.Write("Please enter a valid input: ");
        }

        //Convert row
        trueRow = AbsoluteRow(row, gridLength);

        //Output
        return (row, trueRow, column);
    }
    private static int AbsoluteRow(int trueRow, int gridLength)
    {
        //Declare variables
        int[] convert;
        int rowNum;

        //Set variables
        convert = new int[gridLength];
        for (int i = 1; i < gridLength; i++)
        {
            convert[i] = i;
        }

        //Convert row
        rowNum = Array.IndexOf(convert, trueRow);
        Array.Reverse(convert);
        rowNum = convert[trueRow];

        //Output
        return rowNum;
    }
}