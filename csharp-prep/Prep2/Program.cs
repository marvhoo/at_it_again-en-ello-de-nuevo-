using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hey there what's your grade percentage?: ");
        string valueFromInput = Console.ReadLine();
        Console.Beep();

        int a = 100;
        int b = 89;
        int c = 79;
        int d = 69;
        int x = int.Parse(valueFromInput);
        
        if (x <= d)
        {
            Console.Write("You got a 'D', put more effort.");
        }
        else if (x <= c)
        {
            if (x >= 77)
            {
                Console.Write("You got a 'C+', cool.");
            }
            else if (x <= 73)
            {
                Console.Write("You got a 'C-', You can do more.");
            }
            else
            {
                Console.Write("You got a 'C', not bad.");
            }
        }
        else if (x <= b)
        {
            if (x >= 87)
            {
                Console.Write("You got a 'B+', feels good don't it?.");
            }
            else if (x <= 83)
            {
                Console.Write("You got a 'B-', keep at it.");
            }
            else
            {
                Console.Write("You got a 'B', sweet innit.");
            }
        }
        else if (x <= a)
        {
            if (x >= 94)
            {
                Console.Write("You got an 'A', you're a genius.");
                Console.Beep();
            }
            else (x <= 93)
            {
                Console.Write("You got an 'A-', Outstanding!!");
                Console.Beep();
            }
        }
        else
        {
            Console.Write("Care to try next semester!!");
            Console.Beep();
        }
    }
}