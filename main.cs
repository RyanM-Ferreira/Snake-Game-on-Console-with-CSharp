class Program
{
  const int startGame = 0;
  const int optionsMenu = 1;
  const int quit = 2;

  const double version = 0.5;

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
      Console.SetCursorPosition(0, 0);

      Console.WriteLine("\n=====================================");
      Console.WriteLine("|  SNAKE GAME - C# CONSOLE          |");
      Console.WriteLine("=====================================\n");

      Console.WriteLine(options == startGame ? "-> Start Game" : "   Start Game");
      Console.WriteLine(options == optionsMenu ? "-> Options" : "   Options");
      Console.WriteLine(options == quit ? "-> Quit" : "   Quit");

      Console.WriteLine("\n-------------------------------------");
      Console.WriteLine("|   Use arrows to navigate          |");
      Console.WriteLine("|   Press ENTER to select!          |");
      Console.WriteLine("-------------------------------------\n");


      Console.WriteLine($"Version: v{version}");

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