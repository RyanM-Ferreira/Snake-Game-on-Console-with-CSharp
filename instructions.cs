class Instructions
{
    public static void ShowInstructions()
    {
        Console.Clear();

        string title = "=   GAME INSTRUCTIONS   =\n\n";
        string controls = "Use the arrow keys to control the snake.\n\n";
        string instructions = "Eat the fruits ($ symbols) to\ngrow the snake and earn points.\n\nAvoid hitting the walls or yourself!\n";
        string key = "\n\nPress Enter to start the game...";

        Dialogues.DialoguesEffect(title + controls + instructions + key, 25);

        while (true)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

            if (pressedKey.Key == ConsoleKey.Enter)
            {
                InGame.GameFunction();
                break;
            }
        }
    }
}