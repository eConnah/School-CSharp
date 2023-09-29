internal class Program
{
    private static void Main(string[] args)
    {
        //Declare vatiables
        char[] wordle;
        char[] userGuess;
        char[] comparisonArray;
        char[][] presetArrays;
        string wordleOutput;
        string userGuessOutput;
        int randomIndex;
        Random randomInt;

        //Preset arrays
        presetArrays = new char[][] {
            new char[5] {'p','i','z','z','a'},
            new char[5] {'b','r','e','a','d'},
            new char[5] {'s','u','s','h','i'},
            new char[5] {'s','t','e','a','k'},
            new char[5] {'p','a','s','t','a'},
            new char[5] {'t','a','c','o','s'},
            new char[5] {'c','a','k','e','s'},
            new char[5] {'c','u','r','r','y'},
            new char[5] {'c','h','i','p','s'},
            new char[5] {'c','r','i','s','p'},
        };

        //Set variables
        randomInt = new Random();
        randomIndex = randomInt.Next(0,presetArrays.Length);
        wordle = presetArrays[randomIndex];
        userGuessOutput = "initialOne";
        wordleOutput = "initialTwo";


        //Output one
        Console.WriteLine("The key for this wordle is:");
        Console.WriteLine("x = Not a letter.");
        Console.WriteLine("* = Is a letter.");
        Console.WriteLine("o = Is the letter.");

        //Loop
        for (int i = 0; i < 6; i++)
        {
            //Set variables
            userGuess = UserInput();
            comparisonArray = Comparer(userGuess, wordle);

            //Output two
            Console.WriteLine($"{userGuess[0]} {userGuess[1]} {userGuess[2]} {userGuess[3]} {userGuess[4]}");
            Console.WriteLine($"{comparisonArray[0]} {comparisonArray[1]} {comparisonArray[2]} {comparisonArray[3]} {comparisonArray[4]}");
            Console.WriteLine();  

            //Convert
            userGuessOutput = new string(userGuess);
            wordleOutput = new string(wordle);

            //Escape
            if (userGuessOutput == wordleOutput)
            {
                break;
            }
        }

        //Output three
        if (userGuessOutput == wordleOutput)
        {
           Console.WriteLine("Congratulations you found it."); 
        } else
        {
            Console.WriteLine("Damn you failed.");
        }
        
    }
    private static char[] UserInput()
    {
        //Declare variables
        string wordleGuessS;
        char[] wordleGuessA;

        //Set variables
        do
        {
            Console.Write("Please enter your 5 letter guess: ");
            wordleGuessS = Console.ReadLine()?.Trim().ToLower();
            wordleGuessA = wordleGuessS.ToCharArray();
            if (wordleGuessA.Length != 5)
            {
                Console.WriteLine("Please make sure your word is 5 letters.");
            } else {
              break;  
            }
        } while (true);

        //Return
        return wordleGuessA;
    }
    private static char[] Comparer(char[] inputGuess, char[] inputWordle)
    {
        //Declare variables
        char[] guessArray;
        char[] wordleArray;
        char[] comparison;

        //Set variables
        (guessArray, wordleArray) = (inputGuess, inputWordle);
        comparison = new char[] {'x','x','x','x','x'};

        //Loop
        for (int i = 0; i < wordleArray.Length; i++)
        {
            if (wordleArray[i] == guessArray[i])
            {
                comparison[i] = 'o';
            } else if (wordleArray.Contains(guessArray[i]))
            {
                comparison[i] = '*';
            } else 
            {
                comparison[i] = 'x';
            }
        }

        //Return
        return comparison;
    }
}