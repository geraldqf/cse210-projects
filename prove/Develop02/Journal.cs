using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _listOfEntries = new List<Entry>();

    public string _fileName = "";

    public Journal()
    {

    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _listOfEntries)
        {
            entry.DisplayEntry();
            
        }
    }

    public void SavingToAFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _listOfEntries)
            {
                outputFile.WriteLine(entry.ConvertToString());
            }
            
        }
    }

    public void LoadingFromAFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        _listOfEntries = new List<Entry>();

        Entry entry = new Entry(); 

        foreach (string line in lines)
        {
               
            string[] parts = line.Split("~|~");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _listOfEntries.Add(entry);
            entry = new Entry();
        }

        

        // foreach (Entry _ in _listOfEntries)
        // {
        //     Console.WriteLine($"Date: {_._date} - Prompt: {_._prompt}");
        //     Console.WriteLine($"{_._response}");
        //     Console.Write($"\n");
        // }
      
    }
}