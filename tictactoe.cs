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

  static int[] LoadGrid(int[] grid)
  {

    return grid;
  }

  static void DrawGrid(int[] grid)
  {
    System.Console.WriteLine("\n {0} | {0} | {0} ", grid[1], grid[2], grid[3]);
    DrawHorizontal();
    System.Console.WriteLine(" 4 | 5 | 6 ");
    DrawHorizontal();
    System.Console.WriteLine(" 7 | 8 | 9 ");
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
    int[] grid = new int[10];

    System.Console.WriteLine("\nWelcome to Tic Tac Toe\nYou know the rules. Here's the grid.\n");
    
    // grid = [ 0 1 2 3 4 5 6 7 8 9 10];

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
