//Skeleton Program code for the AQA A Level Paper 1 Summer 2025 examination
//this code should be used in conjunction with the Preliminary Material
//written by the AQA Programmer Team
//developed in the Visual Studio Community Edition programming environment

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TargetClearCS
{
    internal class Program
    {
        static Random RGen = new();


        static void Main(string[] args)
        {
            bool restart;
            do
            {
                bool optionChosen = false;
                while (!optionChosen)
                {
                    Menu.PrintMenu();
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            Menu.SelectOption(-1);
                            break;
                        case ConsoleKey.DownArrow:
                            Menu.SelectOption(1);
                            break;
                        case ConsoleKey.Enter:
                            Menu.SelectOption(0);
                            optionChosen = true;
                            break;
                        default:
                            break;
                    }
                }

                Console.Write("Back to the menu? (y/n): ");
                restart = Console.ReadLine().ToLower() == "y";
            } while (restart);
        }

        public static void PlayGame(List<int> Targets, List<int> NumbersAllowed, int MaxTarget, int MaxNumber)
        {
            int Score = 0;
            bool GameOver = false;
            string UserInput;
            List<string> UserInputInRPN; // variable that holds the converted user input
            while (!GameOver)
            {
                Console.Clear();
                DisplayState(Targets, NumbersAllowed, Score);
                Console.Write("Enter an expression: ");
                UserInput = Console.ReadLine().Replace(" ", string.Empty);
                Console.WriteLine();
                if (CheckIfUserInputValid(UserInput))
                {
                    UserInputInRPN = ConvertToRPN(UserInput);
                    if (CheckNumbersUsedAreAllInNumbersAllowed(NumbersAllowed, UserInputInRPN, MaxNumber))
                    {
                        if (CheckIfUserInputEvaluationIsATarget(Targets, UserInputInRPN, ref Score))
                        {
                            RemoveNumbersUsed(UserInput, MaxNumber, NumbersAllowed);
                            NumbersAllowed = FillNumbers(NumbersAllowed, MaxNumber);
                        }
                    }
                }
                Score--;
                if (Targets[0] != -1)
                {
                    GameOver = true;
                }
                else
                {
                    UpdateTargets(Targets, MaxTarget);
                }
            }
            Console.Clear();
            Console.WriteLine("Game over!");
            DisplayScore(Score);
        }

        static bool CheckIfUserInputEvaluationIsATarget(List<int> Targets, List<string> UserInputInRPN, ref int Score)
        {
            int UserInputEvaluation = EvaluateRPN(UserInputInRPN);
            bool UserInputEvaluationIsATarget = false;
            if (UserInputEvaluation != -1)
            {
                for (int Count = 0; Count < Targets.Count; Count++)
                {
                    if (Targets[Count] == UserInputEvaluation)
                    {
                        Score += 2;
                        Targets[Count] = -1;
                        UserInputEvaluationIsATarget = true;
                    }
                }
            }
            return UserInputEvaluationIsATarget;
        }

        static void RemoveNumbersUsed(string UserInput, int MaxNumber, List<int> NumbersAllowed)
        {
            List<string> UserInputInRPN = ConvertToRPN(UserInput);
            foreach (string Item in UserInputInRPN)
            {
                if (CheckValidNumber(Item, MaxNumber))
                {
                    if (NumbersAllowed.Contains(Convert.ToInt32(Item)))
                    {
                        NumbersAllowed.Remove(Convert.ToInt32(Item));
                    }
                }
            }
        }


        static void UpdateTargets(List<int> Targets, int MaxTarget)
        {
            for (int Count = 0; Count < Targets.Count - 1; Count++)
            {
                Targets[Count] = Targets[Count + 1];
            }
            Targets.RemoveAt(Targets.Count - 1);
            Targets.Add(GetTarget(MaxTarget));
        }

        static bool CheckNumbersUsedAreAllInNumbersAllowed(List<int> NumbersAllowed, List<string> UserInputInRPN, int MaxNumber)
        {
            List<int> Temp = new();
            foreach (int Item in NumbersAllowed)
            {
                Temp.Add(Item);
            }
            foreach (string Item in UserInputInRPN)
            {
                if (CheckValidNumber(Item, MaxNumber))
                {
                    if (Temp.Contains(Convert.ToInt32(Item)))
                    {
                        Temp.Remove(Convert.ToInt32(Item));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static bool CheckValidNumber(string Item, int MaxNumber)
        {
            if (Regex.IsMatch(Item, "^[0-9]+$"))
            {
                int ItemAsInteger = Convert.ToInt32(Item);
                if (ItemAsInteger > 0 && ItemAsInteger <= MaxNumber)
                {
                    return true;
                }
            }
            return false;
        }

        static void DisplayState(List<int> Targets, List<int> NumbersAllowed, int Score)
        {
            DisplayTargets(Targets);
            DisplayNumbersAllowed(NumbersAllowed);
            DisplayScore(Score);
        }

        static void DisplayScore(int Score) // Prints the current score
        {
            Console.WriteLine($"Current score: {Score}");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void DisplayNumbersAllowed(List<int> NumbersAllowed) // Prints the allowed numbers
        {
            Console.Write("Numbers available: ");
            foreach (int Number in NumbersAllowed)
            {
                Console.Write($"{Number}  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void DisplayTargets(List<int> Targets) // Prints the target array
        {
            Console.Write("|");
            foreach (int T in Targets)
            {
                if (T == -1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(T);
                }
                Console.Write("|");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static List<string> ConvertToRPN(string UserInput)
        {
            int Position = 0; // Current position in userinput
            Dictionary<string, int> Precedence = new() // Holds the available operators and their precedence
            {
                { "+", 2 }, { "-", 2 }, { "*", 4 }, { "/", 4 }, { "^", 6}
            };
            List<string> Operators = new();
            int Operand = GetNumberFromUserInput(UserInput, ref Position);
            List<string> UserInputInRPN = new() { Operand.ToString() };
            Operators.Add(UserInput[Position - 1].ToString());
            while (Position < UserInput.Length)
            {
                Operand = GetNumberFromUserInput(UserInput, ref Position);
                UserInputInRPN.Add(Operand.ToString());
                if (Position < UserInput.Length)
                {
                    string CurrentOperator = UserInput[Position - 1].ToString();
                    while (Operators.Count > 0 && Precedence[Operators[Operators.Count - 1]] > Precedence[CurrentOperator])
                    {
                        UserInputInRPN.Add(Operators[Operators.Count - 1]);
                        Operators.RemoveAt(Operators.Count - 1);
                    }
                    if (Operators.Count > 0 && Precedence[Operators[Operators.Count - 1]] == Precedence[CurrentOperator])
                    {
                        UserInputInRPN.Add(Operators[Operators.Count - 1]);
                        Operators.RemoveAt(Operators.Count - 1);
                    }
                    Operators.Add(CurrentOperator);
                }
                else
                {
                    while (Operators.Count > 0)
                    {
                        UserInputInRPN.Add(Operators[Operators.Count - 1]);
                        Operators.RemoveAt(Operators.Count - 1);
                    }
                }
            }
            return UserInputInRPN;
        }

        static int EvaluateRPN(List<string> UserInputInRPN)
        {
            List<string> S = new();
            while (UserInputInRPN.Count > 0)
            {
                while (!"+-*/^".Contains(UserInputInRPN[0]))
                {
                    S.Add(UserInputInRPN[0]);
                    UserInputInRPN.RemoveAt(0);
                }
                double Num2 = Convert.ToDouble(S[S.Count - 1]);
                S.RemoveAt(S.Count - 1);
                double Num1 = Convert.ToDouble(S[S.Count - 1]);
                S.RemoveAt(S.Count - 1);
                double Result = 0;
                switch (UserInputInRPN[0])
                {
                    case "+":
                        Result = Num1 + Num2;
                        break;
                    case "-":
                        Result = Num1 - Num2;
                        break;
                    case "*":
                        Result = Num1 * Num2;
                        break;
                    case "/":
                        Result = Num1 / Num2;
                        break;
                    case "^":
                        Result = Math.Pow(Num1, Num2);
                        break;
                }
                UserInputInRPN.RemoveAt(0);
                S.Add(Convert.ToString(Result));
            }
            if (Convert.ToDouble(S[0]) - Math.Truncate(Convert.ToDouble(S[0])) == 0.0)
            {
                return (int)Math.Truncate(Convert.ToDouble(S[0]));
            }
            else
            {
                return -1;
            }
        }

        static int GetNumberFromUserInput(string UserInput, ref int Position)
        {
            string Number = "";
            bool MoreDigits = true;
            while (MoreDigits)
            {
                if (Regex.IsMatch(UserInput[Position].ToString(), @"[0-9]"))
                {
                    Number += UserInput[Position];
                }
                else
                {
                    MoreDigits = false;
                }
                Position++;
                if (Position == UserInput.Length)
                {
                    MoreDigits = false;
                }
            }
            if (Number == "")
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(Number);
            }
        }

        static bool CheckIfUserInputValid(string UserInput)
        {
            return Regex.IsMatch(UserInput, @"^([0-9]+[\+\-\*\/\^])+[0-9]+$");
        }

        static int GetTarget(int MaxTarget)
        {
            return RGen.Next(MaxTarget) + 1;
        }

        static int GetNumber(int MaxNumber)
        {
            return RGen.Next(MaxNumber) + 1;
        }

        public static List<int> CreateTargets(int SizeOfTargets, int MaxTarget)
        {
            List<int> Targets = new();
            for (int Count = 1; Count <= 5; Count++)
            {
                Targets.Add(-1);
            }
            for (int Count = 1; Count <= SizeOfTargets - 5; Count++)
            {
                Targets.Add(GetTarget(MaxTarget));
            }
            return Targets;
        }

        public static List<int> FillNumbers(List<int> NumbersAllowed, int MaxNumber)
        {
            while (NumbersAllowed.Count < 5)
            {
                int tempNumber = GetNumber(MaxNumber);
                if (!NumbersAllowed.Contains(tempNumber))
                {
                    NumbersAllowed.Add(tempNumber);
                }
            }
            return NumbersAllowed;
        }

        
    }

    static class Menu
    {
        private static string[] options = new string[] { ">    Tutorial", "     Training Game", "     Normal Game" };
        private static int selectedOption = 0;
        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to countdown, here are your options:");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
        }

        public static void SelectOption(int direction)
        {
            options[selectedOption] = string.Concat(" ", options[selectedOption].AsSpan(1));
            switch (direction)
            {
                case -1:
                    if (selectedOption - 1 >= 0)
                    {
                        selectedOption -= 1;
                    }
                    break;

                case 0:
                    LaunchGame();
                    break;

                case 1:
                    if (selectedOption + 1 <= 2)
                    {
                        selectedOption += 1;
                    }
                    break;

                default:
                    break;
            }
            options[selectedOption] = string.Concat(">", options[selectedOption].AsSpan(1));
        }

        private static void LaunchGame()
        {
            List<int> NumbersAllowed = new(); // The numbers allowed as inputs.
            List<int> Targets; // The targets you have to get
            int MaxNumberOfTargets = 20; // The maximum number of targets.
            int MaxTarget; // The maximum a target can be
            int MaxNumber; // Maximum input given
            switch (selectedOption)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine();
                    BorderText("Training Game", "Version 1.0");
                    Thread.Sleep(2000);
                    MaxNumber = 1000;
                    MaxTarget = 1000;
                    Targets = new() { -1, -1, -1, -1, -1, 23, 9, 140, 82, 121, 34, 45, 68, 75, 34, 23, 119, 43, 23, 119 }; // ! -1 is an empty spot
                    NumbersAllowed = new() { 2, 3, 2, 8, 512 };
                    Program.PlayGame(Targets, NumbersAllowed, MaxTarget, MaxNumber); // Starts the game
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine();
                    BorderText("Normal Game", "Version 1.0");
                    Thread.Sleep(2000);
                    MaxNumber = 10;
                    MaxTarget = 50;
                    Targets = Program.CreateTargets(MaxNumberOfTargets, MaxTarget); // Method to generate targets
                    NumbersAllowed = Program.FillNumbers(NumbersAllowed, MaxNumber);
                    Program.PlayGame(Targets, NumbersAllowed, MaxTarget, MaxNumber); // Starts the game
                    break;
            }
        }

        private static void BorderText(string title, string subtitle = "", ConsoleColor color = ConsoleColor.White)
        {
            int windowWidth = Console.WindowWidth - 2;
            string titleContent = string.Format("║{0," + ((windowWidth / 2) + (title.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (title.Length / 2) + 1) + "}", title, "║");
            string subtitleContent = string.Format("║{0," + ((windowWidth / 2) + (subtitle.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (subtitle.Length / 2) + 1) + "}", subtitle, "║");

            Console.Write("╔");
            Console.Write(new string('═', Console.WindowWidth - 2));
            Console.WriteLine("╗");
            Console.WriteLine(titleContent);
            if (!string.IsNullOrEmpty(subtitle))
            {
                Console.WriteLine(subtitleContent);
            }
            Console.Write("╚");
            Console.Write(new string('═', Console.WindowWidth - 2));
            Console.WriteLine("╝");
        }
    }
}