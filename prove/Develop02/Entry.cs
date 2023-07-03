class Entry
{
    public string date, promptText, entryText;


    public Entry(string _date, string _promptText, string _entryText)
    {
        date       = _date;
        promptText = _promptText;
        entryText  = _entryText;        
    }

    public Entry(string _date, string _entryText)
    {
        date       = _date;
        entryText  = _entryText;
    }
    public void Display()
    {
    
        Console.WriteLine($"Date: {date} - Prompt: {promptText}\n" +
        $"Entry: {entryText}\n");

    }
}