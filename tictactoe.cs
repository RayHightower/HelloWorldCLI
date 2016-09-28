using System;

public class TicTacToe
{

  static void DrawHorizontal()
  {
    System.Console.WriteLine("--------------");
  }

  static void DrawPosts()
  {
    System.Console.WriteLine("    |    |    ");
  }


  static void DrawGrid()
  {
    DrawPosts();
    DrawHorizontal();
    DrawPosts();
    DrawHorizontal();
    DrawPosts();
  }

  /*
  static void GrabMove()
  {
    move = Console.Read();
  }
  */

  public static void Main()
  {
    int move;

    System.Console.WriteLine("\nWelcome to Tic Tac Toe\nYou know the rules. Here's the grid.\n");
    DrawGrid();

    while (true)
    {
      System.Console.WriteLine("\nIt's X's move. Which cell (1 thru 9) should X mark?");

      move = Console.Read();

      DrawGrid();

      System.Console.WriteLine("\nIt's O's move. Which cell (1 thru 9) should O mark?");

      move = Console.Read();

      DrawGrid();

    }

  }
}
