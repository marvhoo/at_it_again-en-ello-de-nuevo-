public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        Console.WriteLine("\nReading from file: ");
        string filename       = "Reflections.txt";

        string[] lines        = System.IO.File.ReadAllLines(filename);

        
        int index         = new Random().Next(lines.Length);
        string randomLine = lines[index];


        return randomLine;
    }
    
}
