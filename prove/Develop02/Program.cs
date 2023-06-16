using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator promptRandom = new PromptGenerator();
        Journal journal = new Journal();

        int menuChoice = 0;
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
                    string promptText = promptRandom.GetRandomPrompt();
                    Console.Write($"{promptText}\n> ");
                    string entryText = Console.ReadLine();
                    string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                    Entry entry = new Entry(date, promptText, entryText);
                    journal.AddEntry(entry);
                    

                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    break;
                case 4: 
                    break;
            }
                    
        }

        
        // Entry entry1 = new Entry();
        

         
        // entry1._promptText = prompt.GetRandomPrompt();
        // Console.WriteLine($"{entry1._promptText}");
        // string input = Console.ReadLine();
        // entry1._entryText = input;
        // entry1._date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");



        // string file = journal.AddEntry(entry1);
        // journal.SaveToFile(entry1);

        // entry1.Display();

        // journal.AddEntry(entry1);
        

        
        // prompt.Display();


    

        
    }

}