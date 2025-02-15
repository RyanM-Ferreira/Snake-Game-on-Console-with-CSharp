using System.ComponentModel.Design;

class Result
{
    public static void CheckGameResult(bool isGameOver, bool Won)
    {
        Console.Clear();

        string key = "\nPress Enter to Return to the Menu\nor R to restart the game!\n";
        string gameEstate = " ";

        if (isGameOver)
        {
            gameEstate = "Game Over!\n";
        }
        else if (Won)
        {
            gameEstate = "You Won!\n";
        }

        Dialogues.DialoguesEffect(gameEstate + key, 50);

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