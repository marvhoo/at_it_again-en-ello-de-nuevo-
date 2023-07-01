using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Marvin", "123456", "Math");
            Console.WriteLine(assignment.GetSummary()+"\n");

            MathAssignment mathAssignment = new MathAssignment("Marvin", "123456", "Fractions", "12.1", "1-10");
            Console.WriteLine(mathAssignment.GetHomeworkList()+"\n");

            WritingAssignment writingAssignment = new WritingAssignment("Marvin", "123456", "European History", "The French Revolution");
            Console.WriteLine(writingAssignment.GetWritinginformation());
        }
    }
}