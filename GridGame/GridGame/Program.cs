internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char[,] gridArray;
        int targetRow;
        int targetColumn;

        //Set variables
        gridArray = new char[,] {
            {' ','1','2','3','4'},
            {'1','x','x','x','x'},
            {'2','x','x','x','x'},
            {'3','x','x','x','x'},
            {'4','x','x','x','x'},
            {'5','x','x','x','x'},
            {'6','x','x','x','x'}
        };

        //Output one
        Console.WriteLine("Here is the current grid.");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{gridArray[i,0]} ");
            Console.Write($"{gridArray[i,1]} ");
            Console.Write($"{gridArray[i,2]} ");
            Console.Write($"{gridArray[i,3]} ");
            Console.WriteLine($"{gridArray[i,4]} ");
        }

        //Update grid
        (targetRow, targetColumn) = Target();
        gridArray[targetRow, targetColumn] = 'O';

        //Output two
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"{gridArray[i,0]} ");
            Console.Write($"{gridArray[i,1]} ");
            Console.Write($"{gridArray[i,2]} ");
            Console.Write($"{gridArray[i,3]} ");
            Console.WriteLine($"{gridArray[i,4]} ");
        }
    }
    private static (int, int) Target()
    {
        //Declare variables
        int column;
        int row;

        //Set variables
        Console.Write("Which column would you like to update: ");
        while (!int.TryParse(Console.ReadLine(), out column) || column > 4 || column < 1)
        {
            Console.Write("Please enter a valid input: ");
        }
        Console.Write("Which row would you like to update: ");
        while (!int.TryParse(Console.ReadLine(), out row) || row > 6 || row < 1) 
        {
            Console.Write("Please enter a valid input: ");
        }

        //Output
        return (row, column);
    }
}