using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // String magicNumber = Console.ReadLine();
        // int magicNumberInt = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 100);

        String guessNumber;
        int guessNumberInt;
        
        do
        {
            Console.Write("What is your guess? ");
            guessNumber = Console.ReadLine();
            guessNumberInt = int.Parse(guessNumber);

            if (guessNumberInt > magicNumberInt)
            {
                Console.WriteLine("Lower");  
            }
            else if (guessNumberInt < magicNumberInt)
            {
                Console.WriteLine("Higher"); 
            }
            else
            {
                Console.WriteLine("You guessed it!");
            } 

        } while (guessNumberInt != magicNumberInt);
    }
}