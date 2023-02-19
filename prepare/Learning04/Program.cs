using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Samuel Bennett", "Multiplication"); 
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("Roberto Rodriguez","Fractions","7.3","8-19");
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        Console.WriteLine(myMathAssignment.GetSummary());

        WritingAssignment myWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World Was II");
        Console.WriteLine(myWritingAssignment.GetWritingInformation());
    }
    
}