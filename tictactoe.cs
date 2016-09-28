using System;

public class TicTacToe
{

  static void DrawHorizontal()
  {
    System.Console.WriteLine("--------------");
  }

  static void DrawPosts()
  {
    System.Console.WriteLine(" 1 | 2 | 3 ");
  }

  static char[] LoadGrid(char[] grid)
  {
    grid[1] = (char)49;
    grid[2] = (char)50;
    grid[3] = (char)51;
    grid[4] = (char)52;
    grid[5] = (char)53;
    grid[6] = (char)54;
    grid[7] = (char)55;
    grid[8] = (char)56;
    grid[9] = (char)57;

    return grid;
  }

  static void DrawGrid(char[] grid)
  {
    System.Console.WriteLine("\n {0} | {1} | {2} ", grid[1], grid[2], grid[3]);
    DrawHorizontal();
    System.Console.WriteLine("\n {0} | {1} | {2} ", grid[4], grid[5], grid[6]);
    DrawHorizontal();
    System.Console.WriteLine("\n {0} | {1} | {2} ", grid[7], grid[8], grid[9]);
  }

  static int GrabMove()
  {

    int move;
    char UserCharacter;

    while (true)
    {

    move = Console.Read() - 48;

    if (move > 0 && move < 10)
      {
        return move;
      }
      else
      {
        UserCharacter = Convert.ToChar(move + 48);
        System.Console.WriteLine("\n{0} is an invalid move. Please try again.", UserCharacter);
      }
    }
  }

  public static void Main()
  {
    int move;
    char[] grid = new char[10];

    System.Console.WriteLine("\nWelcome to Tic Tac Toe\nYou know the rules. Here's the grid.\n");

    LoadGrid(grid);

    DrawGrid(grid);

    while (true)
    {
      System.Console.WriteLine("\nIt's X's move. Which cell (1 thru 9) should X mark?");
      move = GrabMove();
      DrawGrid(grid);
      System.Console.WriteLine("\nX chose: {0}", move);
      System.Console.WriteLine("\nIt's O's move. Which cell (1 thru 9) should O mark?");
      move = GrabMove();
      DrawGrid(grid);
      System.Console.WriteLine("\nO chose: {0}", move);

    }

  }
}
