class Journal
{

    List<Entry> entries;

    public Journal()
    {
      entries = new List<Entry>();   
    }

    public void AddEntry(Entry newEntry)
    {
        
        entries.Add(newEntry);
        Console.WriteLine("Adding entry to journal.\n");
        
    }

    public void DisplayAll()
    {
        
        Console.WriteLine("Displaying all entries: \n");
        foreach (Entry entry in entries)
        {
            entry.Display();

        }

    }

    public void SaveToFile(string file)
    {

        Console.WriteLine("Saving to file...\n");

        List<string> logs = new List<string>();

        foreach (Entry entry in entries)
        {
            string entryAsCSV = $"{entry.date}|{entry.promptText}|{entry.entryText}";
            logs.Add(entryAsCSV);
        }

        File.WriteAllLines(file, logs);

    }

    public void LoadFromFile(string file)
    {
        
        Console.WriteLine($"\nLoading from file... {file}.\n" 
        + "After the beep your logs will be available for display.\n");
        Console.Beep();
        
        List<string> logs = File.ReadAllLines(file).ToList();
        foreach (string log in logs)
        {
            string[] items = log.Split('|');
            Entry entry = new Entry(items[0], items[1], items[2]);

            entries.Add(entry);
        }

    }
}