using System.ComponentModel.Design;

class Result
{
    public static void CheckGameResult(bool isGameOver, bool Won)
    {
        Console.Clear();

        string key = "\nPress Enter to Return to the Menu\nor R to restart the game!\n";
        string gameResult = " ";

        if (isGameOver)
        {
            gameResult = "Game Over!\n";
        }
        else if (Won)
        {
            gameResult = "You Won!\n";
        }

        Dialogues.DialoguesEffect(gameResult + key, 15);

        while (true)
        {
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