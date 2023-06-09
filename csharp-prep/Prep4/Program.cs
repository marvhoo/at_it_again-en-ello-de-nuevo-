using System;

class Program
{
    static void Main(string[] args)
    {
        // List to append numbers to.
        List<int> numbers = new List<int>();

        // Loop to ask user for numbers.
        while (true)
        {
            // Asks user for number.
            Console.Write("Enter a number: ");
            string valueFromInput = Console.ReadLine();

            // Check if user entered "0".
            if (valueFromInput == "0")
            {
                break;
            }

            // Convert string to int.
            int number = int.Parse(valueFromInput);

            // Add number to list.
            numbers.Add(number);
        }

        // Sorts the numbers for the user.
        numbers.Sort();

        // Display for the user.
        string numbersString = string.Join(", ", numbers);
        Console.WriteLine($"List of numbers: {numbersString}");

        // Numbers are added and displayed.
        int sum = numbers.Sum();
        Console.WriteLine($"Sum of numbers: {sum}");

        // Average is calculated and displayed.
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        string averageString = average.ToString("N2");

        // Max and min are calculated and displayed.
        int max = numbers.Max();
        Console.WriteLine($"Biggest number is: {max}");

        int min = numbers.Min();
        Console.WriteLine($"Smallest number is: {min}");

        // Positive numbers are calculated and displayed if any.
        double smallestPositive = double.MaxValue;
        foreach (double number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive == double.MaxValue)
        {
            Console.WriteLine("No positive numbers.");
        }
        else
        {
            Console.WriteLine($"Smallest positive number: {smallestPositive}");
        }



    
    }
}