class Dialogues
{
    public static void DialoguesEffect(string text, int delay)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(delay);
        }

        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
    }
}