
class Scripture
{
    Reference reference;
    List<Word> words;
    

    public Scripture()
    {
        
    }
    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();
        
        List<string> wordList = _text.Split(' ').ToList();
        foreach (string wordString in wordList)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<int> indices = Enumerable.Range(0, words.Count).ToList();

        for (int i = 0; i < words.Count / 3; i++)
        {
            int randomIndex = random.Next(indices.Count);
            int wordIndex = indices[randomIndex];
            indices.RemoveAt(randomIndex);

            words[wordIndex].Hide(); 
        }
    }
    
    public string GetDisplayText()
    {
        string scriptureDisplay = "";

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureDisplay += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureDisplay += new string('_', word.GetDisplayText().Length) + " ";
            }            
        }
        return ($"{reference.GetDisplayText()} {scriptureDisplay}");
    }   

   
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }

  
        



    

}

