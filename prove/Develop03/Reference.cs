public class Reference
{
    private string _reference;
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference()
    {
        
        _book = "Proverbs";
        _chapter = "3";
        _verse = "5";
        _endVerse = "6";    
        _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
    public Reference(string book,
                        string chapter,
                        string verse,
                        string endVerse)
    {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;    
        _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    public Reference(string book,
                        string chapter,
                        string verse)
    {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
           
        _reference = $"{_book} {_chapter}:{_verse}";
    }

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _book = chapter;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(string endVerse)
    {
        _endVerse = endVerse;
    }

    public string Show()
    {
        return _reference;
    }
}