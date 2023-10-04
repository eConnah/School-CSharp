internal class Program
{
  // Create a 3x3 grid for the game
  public static char[,] grid = {
    { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' }
  };

  // Keep track of the number of filled spaces on the grid
  public static int filledSpaces = 0;

  public static void Main(string[] args)
  {
    bool gameOver = false;
    int x = -1;
    int y = -1;

    // Display a welcome message
    Console.WriteLine("WELCOME TO NOUGHTS AND CROSSES\n\n");

    // Display the initial grid
    DisplayGrid();

    // Continue the game until the game is over or all spaces are filled
    while (!gameOver & filledSpaces < 9)
    {
      x = -1;
      y = -1;

      // Player One's turn (O)
      do
      {
        Console.WriteLine("\nPlayer One (O), make your move - enter your coordinates using x and y\n Enter your x value:");
        x = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("\nNow enter your y value:");
        y = Convert.ToInt32(Console.ReadLine()) - 1;

      } while (!CheckMove(x, y));

      // Make O's move on the grid and display the updated grid
      OMove(x, y);
      DisplayGrid();

      x = -1;
      y = -1;

      // Player Two's turn (X)
      do
      {
        // Check if Player One has already won the game or all spaces are filled
        if (CheckGameWon() == 'o' | (filledSpaces == 9))
        {
          break;
        }

        Console.WriteLine("\nPlayer Two (X), make your move - enter your coordinates using x and y\n Enter your x value:");
        x = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("\nNow enter your y value:");
        y = Convert.ToInt32(Console.ReadLine()) - 1;

      } while (!CheckMove(x, y));

      // If Player One hasn't won and there are still empty spaces, make X's move and display the updated grid
      if (CheckGameWon() != 'o' & filledSpaces < 9)
      {
        XMove(x, y);
        DisplayGrid();
      }

      // Check if Player One has won, Player Two has won, or it's a draw
      if (CheckGameWon() == 'o')
      {
        gameOver = true;
        Console.WriteLine("O has won the game!");
      }
      else if (CheckGameWon() == 'x')
      {
        gameOver = true;
        Console.WriteLine("X has won the game!");
      }
      else if (filledSpaces == 9)
      {
        gameOver = true;
        Console.WriteLine("No winner this time, better luck next time");
      }
    }
  }

  // Display the current state of the grid
  public static void DisplayGrid()
  {
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine("-----------");
      for (int j = 0; j < 3; j++)
      {
        Console.Write($"|{grid[i, j]}| ");
      }
      Console.WriteLine("\n-----------");
    }
  }

  // Make O's move on the grid
  public static void OMove(int x, int y)
  {
    grid[x, y] = 'O';
    filledSpaces++;
  }

  // Make X's move on the grid
  public static void XMove(int x, int y)
  {
    grid[x, y] = 'X';
    filledSpaces++;
  }

  // Check if a move is valid

  public static bool CheckMove(int x, int y)
  {
    bool valid = false;

    // Check if the coordinates are within the grid
    if (x < 3 & x >= 0)
    {
      if (y < 3 & y >= 0)
      {
        // Check if the space is available ('-')
        if (grid[x, y] == '-')
        {
          valid = true;
        }
        else
        {
          Console.WriteLine("Space taken, please try again");
        }
      }
      else
      {
        Console.WriteLine("Invalid input, please enter values between 1 and 3");
      }
    }
    else
    {
      Console.WriteLine("Invalid input, please enter values between 1 and 3");
    }
    return valid;
  }

  // Check if any player has won the game
  public static char CheckGameWon()
  {
    int ohoriz = 0;
    int overt = 0;
    int xhoriz = 0;
    int xvert = 0;

    // Check for winning conditions horizontally and vertically
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (grid[i, j] == 'O')
        {
          ohoriz++;
        }
        else if (grid[i, j] == 'X')
        {
          xhoriz++;
        }

        if (grid[j, i] == 'O')
        {
          overt++;
        }
        else if (grid[j, i] == 'X')
        {
          xvert++;
        }
      }

      // Reset the counters if not a winning condition
      if (ohoriz < 3)
      {
        ohoriz = 0;
      }
      if (xhoriz < 3)
      {
        xhoriz = 0;
      }
      if (overt < 3)
      {
        overt = 0;
      }
      if (xvert < 3)
      {
        xvert = 0;
      }
    }

    // Determine the winner based on the counters
    if ((ohoriz + overt) > (xhoriz + xvert))
    {
      return 'o';
    }
    else if (xhoriz + xvert > ohoriz + overt)
    {
      return 'x';
    }
    else if (xhoriz + xvert == 0)
    {
      return 'n';
    }
    else
    {
      return 'd';
    }
  }
}