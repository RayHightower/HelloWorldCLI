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

  public static void Main()
  {
    System.Console.WriteLine("Welcome to Tic Tac Toe\nYou know the rules. Here's the grid.\n");
    DrawGrid();
  }
}
