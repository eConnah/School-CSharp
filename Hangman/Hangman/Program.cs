internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        char[] choiceWord;
        char[] currentWord;
        char guessedLetter;
        int wordLength;
        int guesses;
        bool guessed;

        //Set variables
        guesses = 15;
        guessed = false;
        choiceWord = ChosenWord();
        wordLength = choiceWord.Length;
        currentWord = new char[wordLength];
        for (int i = 0; i < wordLength; i++)
        {
            currentWord[i] = '_';
        }

        //Output
        for (int i = 0; i < guesses; i++)
        {
            Console.WriteLine($"You have {guesses - i} guesses left.");
            guessedLetter = UserInput(choiceWord, currentWord);
            currentWord = CheckGuess(choiceWord, guessedLetter, currentWord);
            guessed = Comparer(currentWord, choiceWord);
            if (guessed)
            {
                Console.WriteLine("Congratulations, you somehow managed.");
                break;
            }
        }
        if (!guessed)
        {
            Console.WriteLine("You failed miserably.");
        }
    }

    private static char[] ChosenWord()
    {
        //Declare variables
        Random randomWord;
        char[][] wordOptions;
        char[] choiceWord;

        //Set varaibles
        randomWord = new Random();
        wordOptions = new char[][]
        {
            new char[] { 'h', 'a', 'm', 'b', 'u', 'r', 'g', 'e', 'r' },
            new char[] { 's', 'p', 'a', 'g', 'h', 'e', 't', 't', 'i' },
            new char[] { 's', 'a', 'n', 'd', 'w', 'i', 'c', 'h' },
            new char[] { 'p', 'a', 'n', 'c', 'a', 'k', 'e' },
            new char[] { 'b', 'u', 'r', 'r', 'i', 't', 'o' },
            new char[] { 'p', 'o', 't', 'a', 't', 'o' },
            new char[] { 'c', 'h', 'o', 'c', 'o', 'l', 'a', 't', 'e' },
            new char[] { 'i', 'c', 'e', 'c', 'r', 'e', 'a', 'm' },
            new char[] { 'p', 'i', 'n', 'e', 'a', 'p', 'p', 'l', 'e' },
            new char[] { 'b', 'a', 'n', 'a', 'n', 'a' },
            new char[] { 's', 't', 'r', 'a', 'w', 'b', 'e', 'r', 'r', 'y' },
            new char[] { 'c', 'o', 'o', 'k', 'i', 'e' },
            new char[] { 'w', 'a', 'f', 'f', 'l', 'e' },
            new char[] { 's', 'a', 'u', 's', 'a', 'g', 'e' },
            new char[] { 'p', 'e', 'a', 'n', 'u', 't', 's' },
            new char[] { 'l', 'a', 's', 'a', 'g', 'n', 'a' }
        };

        //Get random word
        choiceWord = wordOptions[randomWord.Next(0, wordOptions.Length)];
        return choiceWord;
    }

    private static char UserInput(char[] choiceWord, char[] currentGuess)
    {
        //Declare variables
        char userInput;

        //Set variables
        Console.Write($"The current word is: ");
        foreach (char character in currentGuess)
        {
            Console.Write(character);
        }
        Console.WriteLine();
        Console.Write($"Try to guess a letter: ");
        userInput = Convert.ToChar(Console.ReadLine()?.Trim().ToLower() ?? string.Empty);
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine();
        }

        //Return
        return userInput;
    }

    private static char[] CheckGuess(char[] choiceWord, char guessedLetter, char[] currentWord)
    {
        //Declare variables
        int wordLength;

        //Set variables
        wordLength = choiceWord.Length;

        //Loop
        for (int i = 0; i < wordLength; i++)
        {
            if (guessedLetter == choiceWord[i])
            {
                currentWord[i] = guessedLetter;
            }
        }

        //Return
        return currentWord;
    }

    private static bool Comparer(char[] currentWord, char[] choiceWord)
    {
        //Declare variable
        string sCurrentWord;
        string sChoiceWord;

        //Set variables
        sCurrentWord = string.Empty;
        sChoiceWord = string.Empty;
        foreach (char character in currentWord)
        {
            sCurrentWord += character;
        }
        foreach (char character in choiceWord)
        {
            sChoiceWord += character;
        }

        //Return
        return String.Equals(sCurrentWord, sChoiceWord);
    }
}