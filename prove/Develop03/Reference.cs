
class Reference
{
    public string book, chapter,verse, verseStart, verseEnd, text;

    public Reference(string _book, string _chapter, string _verse)
    {
        book = _book;
        chapter = _chapter;
        verseStart = _verse;
    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd)
    {
        book       = _book;
        chapter    = _chapter;
        verse      = _verseStart;
        verseEnd   = _verseEnd;
    }

    public Reference(string _book, string _chapter, string _verseStart, string _verseEnd, string _text)
    {
        book            = _book;
        chapter         = _chapter;
        verseStart      = _verseStart;
        verseEnd        = _verseEnd;
        text            = _text;
    }
    

    public string GetDisplayText()
    {
        string referenceDisplay ="";


        if (verseEnd != null)
        {
            referenceDisplay = $"{book} {chapter}:{verseStart}\n{text}";
        }
        else
        {
            referenceDisplay = $"{book} {chapter}:{verseStart}-{verseEnd}\n{text}";
        }
       
        return referenceDisplay;
    }

    public void Display()
    {
        Console.WriteLine(GetDisplayText());
    }
}

