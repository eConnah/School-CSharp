internal class Program
{
    private const int MaxGuesses = 15;

    private static void Main(string[] args)
    {
        //Declare and initialize variables
        char[] choiceWord;
        char[] currentWord;
        char guessedLetter;
        bool guessed = false;

        //Set variables
        choiceWord = ChosenWord();
        currentWord = InitializeCurrentWord(choiceWord.Length);

        //Loop
        for (int i = 0; i < MaxGuesses; i++)
        {
            Console.WriteLine($"You have {MaxGuesses - i} guesses left.");
            guessedLetter = UserInput(currentWord);
            UpdateCurrentWord(choiceWord, guessedLetter, currentWord);
            guessed = AreWordsEqual(currentWord, choiceWord);

            if (guessed)
            {
                Console.WriteLine("Congratulations, you somehow managed.");
                Console.WriteLine($"The word was: {new string(choiceWord)}");
                break;
            }
        }

        //Output
        if (!guessed)
        {
            Console.WriteLine("You failed miserably.");
            Console.WriteLine($"The word was: {new string(choiceWord)}");
        }
    }

    private static char[] ChosenWord()
    {
        //Declare variables
        string chosenWord;
        Random randomChoice;
        string[] wordOptions = {
            "hamburger", "spaghetti", "sandwich", "pancake", "burrito", "potato",
            "chocolate", "icecream", "pineapple", "banana", "strawberry",
            "cookie", "waffle", "sausage", "peanuts", "lasagna"
        };

        //Set variables
        randomChoice = new();
        chosenWord = wordOptions[randomChoice.Next(0, wordOptions.Length)];

        //Return
        return chosenWord.ToCharArray();
    }

    private static char[] InitializeCurrentWord(int length)
    {
        return Enumerable.Repeat('_', length).ToArray();
    }

    private static char UserInput(char[] currentWord)
    {
        //Declare variables
        char userInput;

        //Set variables
        Console.WriteLine($"The current word is: {string.Join(" ", currentWord)}");
        Console.Write("Try to guess a letter: ");
        userInput = Console.ReadKey().KeyChar;
        Console.Clear();

        //Return
        return userInput;
    }

    private static void UpdateCurrentWord(char[] choiceWord, char guessedLetter, char[] currentWord)
    {
        //Loop
        for (int i = 0; i < choiceWord.Length; i++)
        {
            if (guessedLetter == choiceWord[i])
            {
                currentWord[i] = guessedLetter;
            }
        }
    }

    private static bool AreWordsEqual(char[] currentWord, char[] choiceWord)
    {
        //Return
        return new string(currentWord) == new string(choiceWord);
    }
}