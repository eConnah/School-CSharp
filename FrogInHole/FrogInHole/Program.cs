internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int depth = GetInt("Please enter the depth of the hole: ");
        int jumpHeight = GetInt("Please enter how high the frog can jump: ");
        int fallDistance = GetInt("Please enter how much the frog falls everynight: ");
        int daysTaken = HoleEscapeCalc(depth, jumpHeight, fallDistance);
    }

    private static int GetInt(string question)
    {
        Console.Clear();
        while (true)
        {
            Console.Write(question);
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int parsedInt))
            {
                Console.Clear();
                return parsedInt;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
            }
        }
    }

    private static int HoleEscapeCalc(int depth, int jumpHeight, int fallDistance)
    {
        int currentHeight = 0;
        int currentDay = 1;
        while (true)
        {
            Console.Clear();
            currentHeight += jumpHeight;
            if (currentHeight >= depth)
            {
                Console.WriteLine($"Max Height for Day {currentDay}: {currentHeight}");
                Console.WriteLine($"He finally escaped the {depth}m deep hole on day {currentDay}!");
                Console.ReadLine();
                return currentDay;
            }
            else
            {
                Console.WriteLine($"Max Height for Day {currentDay}: {currentHeight}");
                currentHeight -= fallDistance;
                Console.WriteLine($"End Height for Day {currentDay}: {currentHeight}");
                Console.ReadLine();
                currentDay++;
            }
        }
    }
}