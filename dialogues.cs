class Dialogues
{
    public static void DialoguesEffect(string text, int delay)
    {
        bool isFastMode = false;

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);

            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    isFastMode = true;
                }
            }

            int currentDelay = isFastMode ? 0 : delay;

            Thread.Sleep(currentDelay);
        }

        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
    }
}