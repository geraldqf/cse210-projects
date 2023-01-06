using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage: ");
        String gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);
        String letter;

        if (percentage >= 90)
        {
            //Console.WriteLine("Your grde is A");
            letter = "A";
        }
        else if(percentage >= 80)
        {
            //Console.WriteLine("Your grde is B");
            letter = "B";
        }
        else if(percentage >= 70)
        {
            //Console.WriteLine("Your grde is C");
            letter = "C";
        }
        else if(percentage >= 60)
        {
            //Console.WriteLine("Your grde is D");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("Your grde is F");
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter} ");

        if(percentage >= 70)
        {
            Console.WriteLine("Congratulations your passed the course");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course, we encourage you try the next time");
        }
    }
}