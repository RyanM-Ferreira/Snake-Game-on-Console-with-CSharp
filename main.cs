class Program
{
  const int startGame = 0;
  const int optionsMenu = 1;
  const int quit = 2;

  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Clear();
    ShowMenu();
  }

  static void ShowMenu()
  {
    int options = 0;

    Console.CursorVisible = false;

    while (true)
    {
      Console.Clear();

      Console.WriteLine("Snake Game: \n");

      Console.WriteLine(options == startGame ? "-> Start" : "   Start");
      Console.WriteLine(options == optionsMenu ? "-> Options" : "   Options");
      Console.WriteLine(options == quit ? "-> Quit" : "   Quit");

      Console.WriteLine("\nUse the arrow keys to navigate\nand Enter to select.");
      Console.WriteLine("\nv0.1");

      ConsoleKeyInfo pressedKey = Console.ReadKey(true);

      if (pressedKey.Key == ConsoleKey.UpArrow && options > 0)
      {
        options--;
      }
      else if (pressedKey.Key == ConsoleKey.DownArrow && options < 2)
      {
        options++;
      }

      if (pressedKey.Key == ConsoleKey.Enter)
      {
        if (options == startGame)
        {
          Instructions.ShowInstructions();
          break;
        }
        else if (options == optionsMenu)
        {
          Options.OptionsMenu();
          break;
        }
        else if (options == quit)
        {
          Console.Clear();
          Console.WriteLine("\nSaindo...");
          Thread.Sleep(1000);
          break;
        }
      }
    }
  }
}