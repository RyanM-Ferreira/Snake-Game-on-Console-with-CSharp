class Options()
{
    public static void OptionsMenu()
    {
        int selectedOption = 0;

        Console.Clear();

        while (true)
        {
            Console.SetCursorPosition(0, 0);

            Console.WriteLine("Options Menu:");
            Console.WriteLine("Not implemented yet...\n");

            Console.WriteLine(selectedOption == 0 ? "-> Option 1" : "   Option 1");
            Console.WriteLine(selectedOption == 1 ? "-> Back" : "   Back");

            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            Menu.Navigate(ref selectedOption, ref pressedKey);

            if (pressedKey.Key == ConsoleKey.Enter)
            {
                if (selectedOption == 0)
                {
                    // a implementar
                }
                else if (selectedOption == 1)
                {
                    Program.Main();
                    break;
                }
            }
        }
    }
}