using System;

class Program
{
    static void Main(string[] args)
    {
        // ScriptureGenerator scriptureGenerator       = new ScriptureGenerator();
        Scripture scripture                         = new Scripture();
        Format format                               = new Format();

        int option                                  = 0;
        List<string> options = new List<string>()

        {
            "Welcome to the Scripture Mastery App!",
            "1. Add a scripture",
            "2. Display all scriptures",
            "3. Display scriptures from file",
            "4. Save scriptures to file",
            "5. Generate a random scripture",
            "6. Exit\n",
            "Enter an option:" 
        };

        while (option != 5)
        {
            Console.Write($"{options[0]}\n{options[1]}\n{options[2]}\n" +
            $"{options[3]}\n{options[4]}\n{options[5]}\n{options[6]}\n>");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter book's name:");
                    string book = Console.ReadLine();

                    Console.WriteLine("Enter chapter number:");
                    string chapter = Console.ReadLine();

                    Console.WriteLine("Enter starting verse number:");
                    string verseStart = Console.ReadLine();

                    Console.WriteLine("Enter ending verse number:");
                    string verseEnd = Console.ReadLine();

                    Console.WriteLine("Enter a scripture:");
                    string text = Console.ReadLine();             
                    // willl later have to refer to this code . . .
                    
                    
                    Reference reference = new Reference(book, chapter, verseStart, verseEnd, text);
                    // Scripture scripturee = new Scripture(reference, text);
                    format.AddReference(reference);

                    break;

                case 2:
                    format.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("Loading from file...");
                    format.LoadFromFile("Scriptures.txt");
                    break;

                case 4:
                    Console.WriteLine("Saving to file...");
                    format.SaveToFile("Scriptures.txt");
                    break;

                case 5:
                    ClearConsole();

                    Console.WriteLine("Random scripture to memorize...");
                    string randomScrip = format.NewScripture("Scriptures.txt");
                    string _scripture = format.GetReference(randomScrip);
                    var item = format.ListReference(randomScrip);
                    Reference reference1 = new Reference(item[0], item[1], item[2], item[3]);
                    Scripture scripture1 = new Scripture(reference1, item[4]);
                    
                    
                    
                    // Console.WriteLine(item[4]);
                    

                    

        
                    
                    string userInput = "";
                    
                    while (userInput != "finished")
                    {
                        Console.WriteLine(scripture1.GetDisplayText());
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue or type 'finished' to quit.");
                        userInput = Console.ReadLine();
                        if (userInput != "finished")
                        {
                            scripture1.HideRandomWords();
                            ClearConsole();
                        }
                    }

                    break;
            }

        }

        
    }

        static void ClearConsole()
        {
            Console.Clear();
        }
    
}

