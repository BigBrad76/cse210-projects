using System;

public class Reference
{
    private string _bookBR;
    private int _chapterBR;
    private int _verseBR;
    private int _endVerseBR;

    // Constructor for a single verse (e.g., John 3:16)
    public Reference(string book, int chapter, int verse)
    {
        _bookBR = book;
        _chapterBR = chapter;
        _verseBR = verse;
        _endVerseBR = verse; // End verse is the same if it's a single verse
    }

    // Constructor for a range of verses (e.g., Proverbs 3:5-6)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _bookBR = book;
        _chapterBR = chapter;
        _verseBR = startVerse;
        _endVerseBR = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verseBR == _endVerseBR)
        {
            return $"{_bookBR} {_chapterBR}:{_verseBR}";
        }
        else
        {
            return $"{_bookBR} {_chapterBR}:{_verseBR}-{_endVerseBR}";
        }
    }
}