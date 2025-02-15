class Dialogues
{
    public static void DialoguesEffetc(string text, int delay)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(delay);
        }
    }
}