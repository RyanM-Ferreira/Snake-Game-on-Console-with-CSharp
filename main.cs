class Program
{
  const double version = 0.5;

  public static void Main()
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Clear();
    ShowMenu();
  }

  static void ShowMenu()
  {
    Console.CursorVisible = false;

    int selectedOption = 0;
    ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

    while (true)
    {
      Console.SetCursorPosition(0, 0);

      Console.WriteLine("\n=====================================");
      Console.WriteLine("|  SNAKE GAME - C# CONSOLE          |");
      Console.WriteLine("=====================================\n");

      Console.WriteLine(selectedOption == 0 ? "-> Start Game" : "   Start Game");
      Console.WriteLine(selectedOption == 1 ? "-> Options" : "   Options");
      Console.WriteLine(selectedOption == 2 ? "-> Quit" : "   Quit");

      Console.WriteLine("\n-------------------------------------");
      Console.WriteLine("|   Use arrows to navigate          |");
      Console.WriteLine("|   Press ENTER to select!          |");
      Console.WriteLine("-------------------------------------\n");

      Console.WriteLine($"Version: v{version}");

      Menu.Navigate(ref selectedOption, ref pressedKey);

      if (pressedKey.Key == ConsoleKey.Enter)
      {
        if (selectedOption == 0)
        {
          Instructions.ShowInstructions();
          break;
        }
        else if (selectedOption == 1)
        {
          Options.OptionsMenu();
          break;
        }
        else if (selectedOption == 2)
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