using System.Diagnostics;

internal class Program
{
    private static int Lives;
    private static int Blanks;
    private static List<string> BulletInfo = [];

    private static void Main(string[] args)
    {
    TheBeginning:
        Console.Clear();
        Console.WriteLine("How many lives: ");
        if (!int.TryParse(Console.ReadLine(), out Lives)) { Lives = 0; };

        Console.Clear();
        Console.WriteLine("How many blanks: ");
        if (!int.TryParse(Console.ReadLine(), out Blanks)) { Blanks = 0; };

        for (int i = 0; i < (Lives + Blanks); i++)
        {
            BulletInfo.Add($"Bullet {i + 1}: Unknown");
        }

        while (true)
        {
            if (Lives + Blanks == 0)
            {
                goto TheBeginning;
            }
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
                    UpdateInfo(SelectBullet());
                    break;
                case 3:
                    goto TheBeginning;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    private static int MenuDecision()
    {
        string[] menuItems =
        [
            "Live Shot",
            "Blank Shot",
            "Update Info",
            "Restart",
            "Exit"
        ];
        int selectedMenuItem = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Lives: {Lives}, Blanks: {Blanks}");
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

    private static int SelectBullet()
    {
        int selectedBullet = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a bullet.");
            for (int i = 0; i < BulletInfo.Count; i++)
            {
                if (i == selectedBullet)
                {
                    Console.WriteLine($"> {BulletInfo[i]}");
                }
                else
                {
                    Console.WriteLine($"  {BulletInfo[i]}");
                }
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    selectedBullet = Math.Max(0, selectedBullet - 1);
                    break;
                case ConsoleKey.DownArrow:
                    selectedBullet = Math.Min(BulletInfo.Count - 1, selectedBullet + 1);
                    break;
                case ConsoleKey.Enter:
                    return selectedBullet;
                default:
                    break;
            }
        }
    }

    private static void UpdateInfo(int bullet)
    {
        string[] bulletTypes =
        [
            "Live",
            "Blank",
            "Unknown"
        ];
        int selectedOption = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Select a bullet.");
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