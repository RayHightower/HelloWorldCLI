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
    for (int i = 1; i<10; i++)
    {
      grid[i] = (char)(i+48);
    }

    return grid;
  }

  static void DrawGrid(char[] grid)
  {
    System.Console.WriteLine("\n {0} | {1} | {2} ", grid[1], grid[2], grid[3]);
    DrawHorizontal();
    System.Console.WriteLine(" {0} | {1} | {2} ", grid[4], grid[5], grid[6]);
    DrawHorizontal();
    System.Console.WriteLine(" {0} | {1} | {2} ", grid[7], grid[8], grid[9]);
  }

  static char[] UpdateGrid(int move, char player, char[] grid)
  {

    grid[move] = player;

    return grid;
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
    char player;

    System.Console.WriteLine("\nWelcome to Tic Tac Toe\nYou know the rules. Here's the grid.\n");

    LoadGrid(grid);

    DrawGrid(grid);

    while (true)
    {
      player = 'X';
      System.Console.WriteLine("\n{0}'s move. Which cell (1 thru 9) should {0} mark?", player);
      move = GrabMove(); // Grab the move.
      UpdateGrid(move, player, grid);
      DrawGrid(grid);
      System.Console.WriteLine("\n{0} chose: {1}", player, move);

      player = 'O';
      System.Console.WriteLine("\n{0}'s move. Which cell (1 thru 9) should {0} mark?", player);
      move = GrabMove();
      UpdateGrid(move, player, grid);
      DrawGrid(grid);
      System.Console.WriteLine("\n{0} chose: {1}", player, move);

    }

  }
}
