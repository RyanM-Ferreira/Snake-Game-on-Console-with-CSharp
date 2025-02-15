class Result
{
    public static void CheckGameResult(bool isGameOver, bool Won)
    {
        while (true)
        {
            Console.Clear();

            if (isGameOver)
            {
                Console.WriteLine("Game Over!\n");
                Console.WriteLine("Press Enter to Return to the Menu or R to restart the game!\n");
            }
            else if (Won)
            {
                Console.WriteLine("You Won!\n");
                Console.WriteLine("Press Enter to Return to the Menu or R to restart the game!");
            }

            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

            if (pressedKey.Key == ConsoleKey.Enter)
            {
                Program.Main();
                break;
            }
            else if (pressedKey.Key == ConsoleKey.R)
            {
                InGame.GameFunction();
                break;
            }
        }
    }
}