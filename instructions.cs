class Instructions
{
    public static void ShowInstructions()
    {
        Console.Clear();

        string controls = "- Use the arrow keys to control the snake.\n\n";
        string instructions = "- Eat the fruits ($ symbols) to grow\n  the snake and earn points.\n\n" +
                              "- Avoid hitting the walls or yourself!\n";

        Console.WriteLine("\n=============================\n" +
                       "|     GAME INSTRUCTIONS     |\n" +
                       "=============================\n");

        Dialogues.DialoguesEffect(controls + instructions, 20);
        
        Console.WriteLine("\n=============================\n" +
                     "|  Press ENTER to start...  |\n" +
                     "=============================\n");

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