using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _listOfPrompts = new List<string>();

    public string showPrompt;

    public PromptGenerator()
    {
                        
    }

    public string GeneratePrompts()
    {
        var random = new Random();
        
        int index = random.Next(_listOfPrompts.Count);
        string showPrompt = _listOfPrompts[index];
        Console.WriteLine(showPrompt);
        return showPrompt;
    }

    // public void DisplayPrompt()
    // {
    //     Console.WriteLine(showPrompt);
    // }

}