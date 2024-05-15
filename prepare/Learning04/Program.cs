using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "fractions", "section 7.3", "problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignments writingAssignments = new WritingAssignments("Mary Waters", "European History", "The Cause of World War II");
        Console.WriteLine(writingAssignments.GetWritinInfo());

    }
}