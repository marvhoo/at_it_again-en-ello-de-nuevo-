
class ReflectingActivity : Activity
{
    private int _interval, _index;
    private string _filename, _randomLine;

    public ReflectingActivity()
    {
        this.SetActivityName("Welcome to the Reflecting Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you" 
        + "have shown strength and resilience.\nThis will help you recognize the power you have"
        + "and how you can use it in other aspects of your life.");
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write($"Consider the following prompt: \n--- {GetRandomPrompt()} --- "
        + "\n\nAfer you've pondered, press enter to continue...\n");
        Console.ReadKey();

        Console.Write("\nNow ponder on each of the following questions as they relate to the experience"
        + $"\nYou may begin in: \n");
        ShowCountDown(5);
        Console.Clear();

        _interval = GetDuration() / 6;

        DateTime start              = DateTime.Now;
        DateTime end                = start.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write($"\n> {GetRandomQuestion()}\n");
            ShowSpinner(_interval);
            Console.Beep();

            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(_interval);
            Console.Beep();

            Console.WriteLine($"\nWell done!!");
            ShowSpinner(4);
         
        }
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {       
        Console.Beep();
        string filename             = "Reflections.txt";

        string[] lines              = System.IO.File.ReadAllLines(filename);

        
        _index                      = new Random().Next(lines.Length);
        _randomLine                 = lines[_index];


        return _randomLine;
    }
    
    public string GetRandomQuestion()
    {
        Console.Beep();
        string filename             = "Questions.txt";

        string[] lines              = System.IO.File.ReadAllLines(filename);

        
        int index                   = new Random().Next(lines.Length);
        _randomLine                 = lines[index];


        return _randomLine;
    }   
}

