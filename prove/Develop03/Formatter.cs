class Format
{
    List<Reference> references = new List<Reference>();

    public string GetReference(string _referenced)
    {

        string[] items = _referenced.Split('|');

        return $"{items[0]} {items[1]}:{items[2]}-{items[3]}\n{items[4]}";

    }


    // funtcion will returb a randon list, where each | will be used for Reference parameters
    public List<string> ListReference(string _toReference)
    {
        List<string> line = new List<string>();
        string[] lines = _toReference.Split('|');

        foreach (string item in lines)
        {
            line.Add(item);
        }
        return line;
    }

    public void DisplayAll()
    {
        Console.WriteLine("Displaying all scriptures:\n");
        foreach (Reference reference in references)
        {
            reference.Display();
            Console.WriteLine();   
        }
    }

    public void AddReference(Reference newReference)
    {
        references.Add(newReference);
        Console.WriteLine("Reference added.");
    }

   

    public void LoadFromFile(string file)
    {
        Console.WriteLine($"\nLoading from file... {file}.\n" 
        + "After the beep your logs will be available for display.\n");
        Console.Beep();
        
        List<string> scriptures = File.ReadAllLines(file).ToList();
        foreach (string scripture in scriptures)
        {
            string[] items = scripture.Split('|');
            Reference reference = new Reference(items[0], items[1], items[2], items[3], items[4]);

            references.Add(reference);
        }
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine($"\nSaving to file... {file}.\n" 
        + "After the beep your log will have been saved.\n");
        Console.Beep();

        List<string> scriptures = new List<string>();

        foreach (Reference reference in references)
        {
            string referenceAsCSV = $"{reference.book}|{reference.chapter}|{reference.verseStart}|{reference.verseEnd}|{reference.text}";
            scriptures.Add(referenceAsCSV);
        }
    }

    public string NewScripture()
    {
        List<string> _scriptures = new List<string>();
        string filename         = "Scriptures.txt";

        string[] lines          = System.IO.File.ReadAllLines(filename);

        int index = new Random().Next(lines.Length);
        string randomLine = lines[index];

        return randomLine;
    }
}