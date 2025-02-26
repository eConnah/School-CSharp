internal class Program
{
    private static int Lives;
    private static int Blanks;
    private static List<string> BulletInfo = [];

    private static void Main(string[] args)
    {
        while (true)
        {
            InitializeGame();
            PlayGame();
        }
    }

    private static void InitializeGame()
    {
        BulletInfo.Clear();
        Console.Clear();
        Lives = GetInputInt("How many lives: ");
        Blanks = GetInputInt("How many blanks: ");

        for (int i = 0; i < (Lives + Blanks); i++)
        {
            BulletInfo.Add($"Bullet {i + 1}: ");
        }
    }

    private static int GetInputInt(string prompt)
    {
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            Console.Clear();
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    private static void PlayGame()
    {
        while (Lives + Blanks > 0)
        {
            Console.Clear();
            switch (MenuDecision())
            {
                case 0:
                    Lives--;
                    BulletInfo.RemoveAt(0);
                    break;
                case 1:
                    Blanks--;
                    BulletInfo.RemoveAt(0);
                    break;
                case 2:
                    UpdateInfo(GetInputInt("Which bullet: ") - 1);
                    break;
                case 3:
                    return;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private static int MenuDecision()
    {
        string[] menuItems =
        {
            "Live Shot",
            "Blank Shot",
            "Update Info",
            "Restart",
            "Exit"
        };
        int selectedMenuItem = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- This Round ---");
            Console.WriteLine($"Lives: {Lives}");
            Console.WriteLine($"Blanks: {Blanks}");
            
            if (BulletInfo[0].Length > 10)
            {
                Console.WriteLine($"Next Bullet: Definitely {BulletInfo[0][10..]} (100%)");
            }
            else
            {
                if (Lives > Blanks)
                {
                    Console.WriteLine($"Next Bullet: Probably Live ({Lives / (double)(Lives + Blanks) * 100:0.0}%)");
                }
                else if (Lives == Blanks)
                {
                    Console.WriteLine($"Next Bullet: Either (50%)");
                }
                else
                {
                    Console.WriteLine($"Next Bullet: Probably Blank ({Blanks / (double)(Lives + Blanks) * 100:0.0}%)");
                }
            }
            Console.WriteLine();
            foreach (string info in BulletInfo)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedMenuItem)
                {
                    Console.WriteLine($"> {menuItems[i]}");
                }
                else
                {
                    Console.WriteLine($"  {menuItems[i]}");
                }
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    selectedMenuItem = Math.Max(0, selectedMenuItem - 1);
                    break;
                case ConsoleKey.DownArrow:
                    selectedMenuItem = Math.Min(menuItems.Length - 1, selectedMenuItem + 1);
                    break;
                case ConsoleKey.Enter:
                    return selectedMenuItem;
                default:
                    break;
            }
        }
    }

    private static void UpdateInfo(int bullet)
    {
        string[] bulletTypes =
        {
            "Live",
            "Blank",
            "Unknown"
        };
        int selectedOption = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a bullet type.");
            for (int i = 0; i < bulletTypes.Length; i++)
            {
                if (i == selectedOption)
                {
                    Console.WriteLine($"> {bulletTypes[i]}");
                }
                else
                {
                    Console.WriteLine($"  {bulletTypes[i]}");
                }
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    selectedOption = Math.Max(0, selectedOption - 1);
                    break;
                case ConsoleKey.DownArrow:
                    selectedOption = Math.Min(bulletTypes.Length - 1, selectedOption + 1);
                    break;
                case ConsoleKey.Enter:
                    BulletInfo[bullet] = BulletInfo[bullet][..10] + bulletTypes[selectedOption];
                    return;
                default:
                    break;
            }
        }
    }
}