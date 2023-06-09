using System;

public static class Game
{
    public static void playGame()
    {
                // Create a guess my number game.
        // User will provide the number to be guessed.


        // im adding other functionality, thusthe following is commented out as demo that core requirements are met.
            // Console.Write("What is the magic number? ");
            // string magicNumber = Console.ReadLine();
            //int answer = int.Parse(magicNumber);
        


        Random random = new Random();
        int randomNumber = random.Next(0, 100);
        //Console.WriteLine(randomNumber);

        // If the number guessed is less than the magic number, print "Higher."
        // If the number guessed is greater than the magic number, print "Lower."

        bool gotIt = false;    
        int guessCount = 0;
        


        while (!gotIt)
        {
            // User wil type the number guessed.
            Console.Write("What is your guess? ");
            string numberGuessed = Console.ReadLine();
            int guess = int.Parse(numberGuessed);
        
            if (guess == randomNumber)
            {
                Console.WriteLine("Congrats.");
                gotIt = true;
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Higher.");
            }
            guessCount++;
        }
        Console.WriteLine($"You guessed {guessCount} times.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = false;
        Console.WriteLine("Welcome to the Guess My Number Game.");

        while (!playAgain)
        {
            Game.playGame();
            Console.Write("Would you like to play again? (y/n) ");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                playAgain = false;
            }
            else
            {
                playAgain = true;
            }
        }
        Console.WriteLine("Thanks for playing.");
    }
}