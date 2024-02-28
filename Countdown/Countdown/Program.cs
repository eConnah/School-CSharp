internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int countdown;

        //Set variables
        countdown = GrabNumber("What would you like to countdown from: ");

        //Countdown
        for (int i = countdown; i > 0; i--)
        {
            Console.WriteLine(i);
            Task.Delay(1000).Wait();
            Console.Clear();
        }
        Console.WriteLine("LIFT OFF!");
    }

    private static int GrabNumber(string prompt)
    {
        //Declare variables
        string userInput;
        int number;

        //Set variables
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            userInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (int.TryParse(userInput, out number))
            {
                Console.Clear();
                return number;
            }
            Console.Clear();
            Console.WriteLine("Invalid input please try again.");
        }
    }
}
