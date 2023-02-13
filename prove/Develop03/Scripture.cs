using System;
using System.IO;
using System.Collections.Generic;
public class Scripture
{
    private List<Word> _listOfWords = new List<Word>();
    private Reference _referenceScripture = new Reference();
    private string _text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths";

    private List<Word> _copyListOfWords = new List<Word>();

    public Scripture(string text, Reference referenceScripture)
    {
        _text = text;
        _referenceScripture = referenceScripture;

        // string[] lines = System.IO.File.ReadAllLines(_text);
        
        Word word = new Word(); 

        // foreach (string line in lines)
        {
               
            string[] parts = _text.Split(" ");
            
            for (int i = 0; i < parts.Length; i++) 
            {
                word.SetWord(parts[i]);
                
                _listOfWords.Add(word);
                word = new Word();
            }
                
        }
        _copyListOfWords = _listOfWords;
    }

    public List<Word> GetListOfWords()
    {
        return _listOfWords;
    }

    public void SetListOfWords(List<Word> listOfWords)
    {
        _listOfWords = listOfWords;
    }
    
    public Reference GetReferenceScripture()
    {
        return _referenceScripture;
    }

    public void SetReferenceScripture(Reference referenceScripture)
    {
        _referenceScripture = referenceScripture;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public List<Word> GetCopyListOfWords()
    {
        return _copyListOfWords;
    }
    public List<Word> HideWord(int number)
    {   
        int length = _listOfWords.Count;
        Word myWord = new Word();

        for (int i = 0; i < length; i++)
        {
            if (i == number)
            {
                myWord.SetWord(_listOfWords[i].Hide());
                _listOfWords[i] =  myWord;
                
            }
            else
            {
                
            }
        
        }
        return _listOfWords;          
    }

    public string GetRenderedText()
    {
        string oldText = "";

        foreach (Word item in _listOfWords)
        {
            string newText = item.GetWord();
            oldText = $"{oldText} {newText}";
                   
        }

        return oldText;
    }

    public Boolean IsCompletelyHidden()
    {
        int length = _listOfWords.Count;
        int i = 0;
        
        foreach (Word item in _listOfWords)
        {
            if (item.IsHidden() == true){
                i++;
            }
            else
            {
                
            }
        }

        if (i == length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}