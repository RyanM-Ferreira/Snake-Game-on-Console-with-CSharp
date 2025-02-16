class Menu
{
    public static void Navigate(ref int selectedOption, ref ConsoleKeyInfo pressedKey)
    {
        pressedKey = Console.ReadKey(true);

        if (pressedKey.Key == ConsoleKey.UpArrow && selectedOption > 0)
        {
            selectedOption--;
        }
        else if (pressedKey.Key == ConsoleKey.DownArrow && selectedOption < 2)
        {
            selectedOption++;
        }
    }
}
