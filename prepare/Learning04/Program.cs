using System;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment();
            assignment.SetStudentName("Marvin Galicia");
            assignment.SetStudentID("123456");
            assignment.SetTopic("Multiplication");
            Console.WriteLine(assignment.GetSummary());

            Console.WriteLine();

            MathAssignment mathAssignment = new MathAssignment();
            mathAssignment.SetStudentName("Marv Galicia");
            mathAssignment.SetStudentID("327-1067");
            mathAssignment.SetTopic("fractions");
            mathAssignment.SetTextbookSection("7.3");
            mathAssignment.SetProblem("8-19");
            Console.WriteLine(mathAssignment.GetHomeworkList());
    
            Console.WriteLine();
            
            WritingAssignment writingAssignment = new WritingAssignment();
            writingAssignment.SetStudentName("Alex Galicia");
            writingAssignment.SetStudentID("277-3331");
            writingAssignment.SetTopic("European History");
            writingAssignment.SetTitle("The French Revolution by Alex Galicia");
            Console.WriteLine(writingAssignment.GetWritinginformation());


        }
    }
}