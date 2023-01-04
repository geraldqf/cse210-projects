using System;

class Program
{
    static void Main(string[] args)
    {
        // My first C# program
        // Ask for your first name
        Console.WriteLine("What is your first name? ");
        String first_name = Console.ReadLine();

        // Ask for your last name
        Console.WriteLine("What is your last name? ");
        String last_name = Console.ReadLine();

        // Show the greeting like James Bond style
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}. ");
        // Thank you
    }
}