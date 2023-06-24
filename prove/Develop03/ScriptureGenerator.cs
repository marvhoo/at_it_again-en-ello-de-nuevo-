
class ScriptureGenerator
{
    public string GenerateScripture()
    {
        Console.WriteLine("\nReading from file: ");
        List<string> _scriptures = new List<string>();
        string filename          = "Scriptures.txt";

        string[] lines           = System.IO.File.ReadAllLines(filename);

        int index                = new Random().Next(lines.Length);
        string randomLine        = lines[index];

        return randomLine;
    }

    
}