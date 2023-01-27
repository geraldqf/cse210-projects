public class Entry
{
    public string _date = "";

    public string _prompt = "";

    public string _response = "";

    public Entry()
    {

    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    
    public string ConvertToString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.Write($"\n");
    }
}