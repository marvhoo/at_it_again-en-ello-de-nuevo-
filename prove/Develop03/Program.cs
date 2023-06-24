using System;

class Program
{
    static void Main(string[] args)
    {
        // scriptureGenerator scriptureGenerator = new scriptureGenerator();
        // Scripture scripture = scrip

        ClearConsole();
        string userInput = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own\n" +
        "understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (userInput != "finished")
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'finished' to quit.");
            userInput = Console.ReadLine();
            if (userInput != "finished")
            {
                scripture.HideRandomWords();
                ClearConsole();
            }
        }
    }

    static void ClearConsole()
    {
        Console.Clear();
    }
}

