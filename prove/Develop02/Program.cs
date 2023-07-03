using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator promptRandom = new PromptGenerator();
        Journal journal              = new Journal();

        int menuChoice               = 0;
        List<string> menu = new List<string>
        {
            "Please select from the following options:",
            "1. Add Entry",
            "2. View All Entries",
            "3. Load Entries from File",
            "4. Save Entries to File",
            "5. Exit\n",
            "Enter your selection:"
        };

        Console.WriteLine("Welcome to the Journal App!\n");

        while (menuChoice != 5)
        {
            Console.Write($"{menu[0]}\n{menu[1]}\n{menu[2]}\n" +
            $"{menu[3]}\n{menu[4]}\n{menu[5]}\n{menu[6]}\n> ");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.Write("Would you like to add entry with a prompt? (y/n): ");
                    string addEntryChoice = Console.ReadLine();
                    if (addEntryChoice == "n")
                    {
                        Console.Write("Enter your entry: ");
                        string entryText = Console.ReadLine();
                        string date = DateTime.Now.ToString("MM dd/yyyy HH:mm:ss");

                        Entry entry = new Entry(date, entryText);
                        journal.AddEntry(entry);
                        break;
                    }
                    else
                    {
                        string promptText = promptRandom.GetRandomPrompt();
                        Console.Write($"{promptText}\n> ");
                        string entryText = Console.ReadLine();
                        string date = DateTime.Now.ToString("MM dd/yyyy HH:mm:ss");

                        Entry entry = new Entry(date, promptText, entryText);
                        journal.AddEntry(entry);
                        break;
                    }

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("Name of the file to load from: ");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                    
                case 4:
                    Console.WriteLine("Name of the file to save to: ");
                    string fileNameSave = Console.ReadLine();
                    journal.SaveToFile(fileNameSave); 
                    break;
            }
                    
        }

    }

}