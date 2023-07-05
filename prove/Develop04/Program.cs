using System;


class Program
{
    static void Main(string[] args)
    {

        int userChoice = 0;
        List<string> menu = new List<string>
        {
            "Menu Opttions",
            "1. Breathing Activity",
            "2. Reflecting Activity",
            "3. Listing Activity",
            "4. Exit"
        };
        
        while (userChoice != 4)
        {
            Console.Clear();
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            Console.Write("Enter a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }
        };
    }
    static void ClearConsole()
    {
        Console.Clear();
    }
}
