using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word();
        
        Reference myReference = new Reference();
        myReference.SetBook("Proverbs");
        myReference.SetChapter("3");
        myReference.SetVerse("5");
        myReference.SetEndVerse("6");
        
        string mytext = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture myScripture = new Scripture(mytext, myReference);

        Console.Clear();
        Console.WriteLine($"{myReference.GetReference()} {myScripture.GetText()}");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = "";
        input = Console.ReadLine();
        List<int> randomNumbers = new List<int>();

        int length = myScripture.GetListOfWords().Count;
                
        while ((input != "quit") && (myScripture.IsCompletelyHidden() != true))
        {
            // int length = myScripture.GetListOfWords().Count;
            
            Random rnd = new Random();
            int num1 = rnd.Next(length);
            if (randomNumbers.Count() != length)
            {
            randomNumbers.Add(num1);    
            }
            
            int num2 = rnd.Next(length);
            while (num2 == num1 | randomNumbers.Contains(num2))
            {
                num2 = rnd.Next(length);
            }
            if (randomNumbers.Count() != length)
            {
                randomNumbers.Add(num2);    
            }
            
            int num3 = rnd.Next(length);
            while (num3 == num1 | num3 == num2 | randomNumbers.Contains(num3))
            {
                num3 = rnd.Next(length);
            }
            if (randomNumbers.Count() != length)
            {
                randomNumbers.Add(num3);    
            }
            

            myScripture.HideWord(num1);
            myScripture.HideWord(num2);
            myScripture.HideWord(num3);

            Console.Clear();
            Console.WriteLine($"{myReference.GetReference()} {myScripture.GetRenderedText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();
            
        }
                
    }
}