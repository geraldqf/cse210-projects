public class Word
{
    private string _word;

    private Boolean _isShown;

    private string _wordOriginal;

    public Word()
    {
        _word = "";
        _wordOriginal =_word;

        int length = _word.Length;

        string dashesCompare = String.Concat(Enumerable.Repeat("_", length));

        if (_word == dashesCompare){

            _isShown = false;

        }
        else
        {
            _isShown = true;
        }    
    
    }

    // public Word(string word, Boolean isShown)
    // {
    //     _word = word;
    //     _isShown = isShown;
    // 
    // }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public Boolean GetIsShown()
    {
        return _isShown;
    }

    // public void SetIsShown(Boolean isShown)
    // {
    //     _isShown = isShown;
    // }

    public string GetWordOriginal()
    {
        return _wordOriginal;
    }

    public string GetUnderScores()
    {
        int length = _word.Length;

        string underScores = String.Concat(Enumerable.Repeat("_", length));

        return underScores;
    }

    public Boolean IsHidden()
    {
        string hiddenCompare = this.GetUnderScores();

        if(_word == hiddenCompare){
            _isShown = false;
            return true;
            
        }
        else
        {
           _isShown = true;
           return false;
        }
        
    }
    public string Hide()
    {
        string hide = this.GetUnderScores();

        if(_word == hide){ 
            _isShown = false;
        }
        else
        {
            _word = hide;
            _isShown = false;
        }
        return _word;                
    }

    public string Show()
    {
        string showCompare = this.GetUnderScores();

        if(_word == showCompare){
            _word = _wordOriginal;
            _isShown = true;
        }
        else
        {
            _isShown = true;
        }
        return _word;
    }

    

    public string GetRenderedText() 
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        string renderCompare = this.GetUnderScores();
        
        if(_word == renderCompare){
            _isShown = false;
                        
        }
        else
        {
           _isShown = true;
        }
        return _word;  
            
    }
}