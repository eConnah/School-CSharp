internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int playerOneNum;
        int playerTwoGuess;

        //Set variables
        playerTwoGuess = 924;
        do
        {
            Console.WriteLine("Player One please enter a number between 1 - 10: ");
            playerOneNum = Convert.ToInt32(Console.ReadLine());
            if (playerOneNum < 1 || playerOneNum > 10)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        } while (playerOneNum < 1 || playerOneNum > 10);

        //Loop
        for (int i = 0; i < 5 & playerOneNum != playerTwoGuess; i++)
        {
            Console.WriteLine("Player Two please enter your guess between 1 - 10: ");
            playerTwoGuess = Convert.ToInt32(Console.ReadLine());
            if (playerOneNum != playerTwoGuess & i < 4)
            {
                Console.WriteLine("Wrong, guess again.");
            }
        }

        //Output
        if (playerOneNum == playerTwoGuess){
            Console.WriteLine("Congratulations, you guessed correctly.");
        } else {
            Console.WriteLine("Unfortunately, you failed every guess.");
        }
    }
}