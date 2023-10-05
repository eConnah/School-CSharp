internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char[,] gridArray;
        int gridWidth;
        int gridLength;
        int oldRow;
        int oldColumn;
        int x;
        int y;

        //Set variables
        gridArray = InitializeGrid();
        gridWidth = gridArray.GetLength(1);
        gridLength = gridArray.GetLength(0);
        oldColumn = x = y = 1;
        oldRow = AbsoluteRow(1, gridLength);

        //Output grid
        PrintGrid(gridArray);

        //Loop
        while (true)
        {
            //Update grid
            (y, x) = Target(gridWidth, gridLength);
            if (IsMoveValid(oldRow, y, oldColumn, x))
            {
                gridArray[oldRow, oldColumn] = '.';
                oldColumn = x;
                oldRow = y;
                gridArray[y, x] = 'O';
            }

            //Output grid
            PrintGrid(gridArray);
        }
    }

    private static char[,] InitializeGrid()
    {
        return new char[,]
        {
            {'7',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'6',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'5',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'4',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'3',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'2',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {'1','O',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ','1','2','3','4','5','6','7','8','9','A','B','C','D','E'}
        };
    }

    private static void PrintGrid(char[,] gridArray)
    {
        //Declare variables
        int gridLength = gridArray.GetLength(0);
        int gridWidth = gridArray.GetLength(1);

        //Output
        Console.WriteLine("Here is the current grid. You may only move 1 square.");
        for (int length = 0; length < gridLength; length++)
        {
            for (int width = 0; width < gridWidth; width++)
            {
                Console.Write($"{gridArray[length, width]} ");
            }
            Console.WriteLine();
        }
    }

    private static (int, int) Target(int gridWidth, int gridLength)
    {
        //Declare variables
        int column;
        int row;
        string columnInputA;
        char columnInputB;
        Dictionary<char, int> hexCoords;

        //Dictionary for hex
        hexCoords = new()
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
        row = AbsoluteRow(row, gridLength);

        //Output
        return (row, column);
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

    private static bool IsMoveValid(int oldRow, int y, int oldColumn, int x)
    {
        if ((Math.Pow((oldRow - y), 2) == 1 || oldRow - y == 0) && (Math.Pow((oldColumn - x), 2) == 1 || oldColumn - x == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}