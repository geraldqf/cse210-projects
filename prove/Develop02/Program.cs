using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        prompt._listOfPrompts.Add("Who was the most interesting person I interacted with today?");
        prompt._listOfPrompts.Add("What was the best part of my day?");
        prompt._listOfPrompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._listOfPrompts.Add("What was the strongest emotion I felt today?");
        prompt._listOfPrompts.Add("If I had one thing I could do over today, what would it be?");
        
        Menu menu = new Menu();
        Journal myJournal = new Journal();
        List<Entry> entries = myJournal._listOfEntries;
        
        Entry myEntry = new Entry();

        string input = "";
        while (input != "5")
        {
            menu.DisplayMenu();
            input = Console.ReadLine();
      
            switch(input)
            {
                case "1":
                    
                    myEntry._prompt = prompt.GeneratePrompts();
                    
                    myEntry._response = Console.ReadLine();
                    myEntry._date = myEntry.GetDate();
                    
                    entries.Add(myEntry);
                    myEntry = new Entry();
                    break;
                case "2":
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    Console.WriteLine("What is the filename?");
                    myJournal._fileName = Console.ReadLine();
                    myJournal.LoadingFromAFile();
                    entries = myJournal._listOfEntries;
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    myJournal._fileName = Console.ReadLine();
                    myJournal.SavingToAFile();
                    break;
                case "5":
                    break;
                default:
                    break;

            }
        }



    }
}