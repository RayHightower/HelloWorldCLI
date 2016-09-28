public class TicTacToe
{

  static void DrawHorizontal()
  {
    System.Console.WriteLine("--------------");
  }

  static void DrawPosts()
  {
    System.Console.WriteLine("|   |    |   |");
  }


  static void DrawGrid()
  {
    DrawPosts();
    DrawHorizontal;
    DrawPosts();
    DrawHorizontal();
  }

  public static void Main()
  {
    System.Console.WriteLine("Hello World!!!!!");
    DrawGrid();
  }
}
