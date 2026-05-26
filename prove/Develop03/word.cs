using System;

public class WordBR
{
    private string _textBR;
    private bool _isHiddenBR;

    public WordBR(string text)
    {
        _textBR = text;
        _isHiddenBR = false;
    }

    public void Hide()
    {
        _isHiddenBR = true;
    }

    public void Show()
    {
        _isHiddenBR = false;
    }

    public bool IsHidden()
    {
        return _isHiddenBR;
    }

    public string GetDisplayText()
    {
        if (_isHiddenBR)
        {
            // Replaces the word with underscores of matching length
            return new string('_', _textBR.Length);
        }
        else
        {
            return _textBR;
        }
    }
}