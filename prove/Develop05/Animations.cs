
class Animations
{
    private int _duration;
    private readonly int _spinnerCounter;

    public Animations()
    {
        _spinnerCounter = _duration = 0;
    }

     public static void ShowSpinner(int seconds)
        {
            DateTime start = DateTime.Now;
        _ = start.AddSeconds(seconds);
        List<string> spinner = new() { "/", "-", "\\", "|"};

            for (int i = seconds; i >= 1; i--)
            {
                foreach (string s in spinner)
                {
                    Console.Write(s);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                }
            }   
            Console.Write(" ");
        }
}