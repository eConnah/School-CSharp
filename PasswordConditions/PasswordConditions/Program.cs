using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string password;
        string passwordGuess;

        //Set variables
        Console.WriteLine("Please enter a password: ");
        password = Console.ReadLine()?.Trim() ?? String.Empty;

        //Check
        do
        {
            Console.WriteLine("Please enter the password again: ");
            passwordGuess = Console.ReadLine()?.Trim() ?? string.Empty;
            if (password != passwordGuess)
            {
                Console.WriteLine("Incorrect Password.");
            }
        } while (password != passwordGuess);
        Console.WriteLine("Correct Password.");
    }
}