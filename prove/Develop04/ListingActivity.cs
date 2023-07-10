
class ListingActivity : Activity
{
    private readonly List<string> usedPrompts        = new();
    private string[] lines;
    private readonly Random random                   = new();
    private int _count                      = 0;
    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things in your life by having you\n"
        + "list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowDotAnimation();
        Console.WriteLine($"\nList as many responses you can to the following prompt:"
        + $"\n--- {GetRandomPrompt()} ---\nYou may begin in: ");
        ShowCountDown(5);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetDuration());

        
        while (DateTime.Now < end)
        {   
        
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        ShowDotAnimation();
        Console.WriteLine("\nWell done!");
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        if (lines == null)
        {
            string filename = "ListingPrompts.txt";
            lines = System.IO.File.ReadAllLines(filename);
        }

        if (usedPrompts.Count == lines.Length)
        {
        // All prompts have been used, reset the list
            usedPrompts.Clear();
        }

        string randomLine;
        do
        {
            int index = random.Next(lines.Length);
            randomLine = lines[index];
        } while (usedPrompts.Contains(randomLine));

        usedPrompts.Add(randomLine);
        return randomLine;
    }


}