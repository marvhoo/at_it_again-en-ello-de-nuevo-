public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        Console.WriteLine("\nReading from file: ");
        List<string> _prompts = new List<string>();
        string filename       = "Prompts.txt";

        string[] lines        = System.IO.File.ReadAllLines(filename);

        
        int index         = new Random().Next(lines.Length);
        string randomLine = lines[index];


        return randomLine;
    }
    
}
