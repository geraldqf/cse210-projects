using System;

class Program
{
    static void Main(string[] args)
    {
        // our Main function should then call each of these functions saving the return values 
        // and passing data to them as necessary.

        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int numberYetSquared = SquareNumber(number);

        DisplayResult(name, numberYetSquared);

        // Sample output of the program could look as follows:
        // Welcome to the program!
        // Please enter your name: Brother Burton
        // Please enter your favorite number: 42
        // Brother Burton, the square of your number is 1764
        
    }

    // For this assignment, write a C# program that has several simple functions:

    // DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    // PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    
    // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string getNumber = Console.ReadLine();
        int userNumber = int.Parse(getNumber);
        return userNumber;
    }
    
    // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int integerNumber)
    {
        int numberSquared = integerNumber * integerNumber; 
        return numberSquared;
    }
    
    // DisplayResult - Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }

    
}