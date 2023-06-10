using System;

class Program
{

    // Function will displau a welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function will ask user for their name.
    static string AskForName()
    {
        Console.WriteLine("Please enter your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    // User will be asked for their age.
    static int AskForAge()
    {
        Console.WriteLine("What is your age?: ");
        string age = Console.ReadLine();
        int ageNumber = int.Parse(age);
        return ageNumber;
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = AskForName();
        double squaredNumber = Math.Pow(AskForAge(), 2);
        Console.WriteLine($"{name}, the square of your age is {squaredNumber}.");
    }
}