using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _referenceBR;
    private List<WordBR> _wordsBR;

    public Scripture(Reference reference, string text)
    {
        _referenceBR = reference;
        _wordsBR = new List<WordBR>();

        // Split the text by spaces and populate the list of Word objects
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _wordsBR.Add(new WordBR(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Find all words that are NOT already hidden (Exceeds Core Requirements logic)
        List<WordBR> visibleWords = _wordsBR.FindAll(w => !w.IsHidden());

        // If there are fewer visible words left than requested, just hide what's left
        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex); // Prevent picking the same word in this turn
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (WordBR word in _wordsBR)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_referenceBR.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        // Returns true if all words return true for IsHidden()
        return _wordsBR.All(w => w.IsHidden());
    }
}