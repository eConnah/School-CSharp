internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many boxes are there: ");
        int boxes = int.Parse(Console.ReadLine());
        int successfulBoxes = 1;
        int[,] boxesArray = new int[boxes, 3];
        string[] inputDimensions;
        for (int i = 0; i < boxes; i++)
        {
            Console.Clear();
            Console.Write($"Please enter the dimensions of box {i + 1}: ");
            inputDimensions = Console.ReadLine().Split(' ');
            Array.Sort(inputDimensions);
            for (int j = 0; j < 3; j++)
            {
                boxesArray[i, j] = int.Parse(inputDimensions[j]);
            }
        }
        Console.Clear();
        for (int i = 0; i < boxesArray.GetLength(0) - 1; i++)
        {
            if (boxesArray[i, 0] >= boxesArray[i + 1, 0])
            {
                break;
            }
            else if (boxesArray[i, 1] >= boxesArray[i + 1, 1])
            {
                break;
            }
            else if (boxesArray[i, 2] >= boxesArray[i + 1, 2])
            {
                break;
            }
            else
            {
                successfulBoxes++;
            }
        }
        Console.WriteLine($"The final box will be made of {successfulBoxes} boxes.");
    }
}