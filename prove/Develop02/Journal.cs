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
        Console.WriteLine("Adding entry to journal: ");
        
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

        Console.WriteLine("Saving to file: ");
        string filename = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
    
                outputFile.WriteLine($"{entry._date}\n{entry._promptText}\n{entry._entryText}\n");
    
            }
        }

    }

    public void LoadFromFile(string file)
    {
        
    }
}