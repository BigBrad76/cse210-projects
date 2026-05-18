using System;

public class Fraction
{
    private int _topBR;
    private int _bottomBR;

    public Fraction()
    {
        // Default to 1/1
        _topBR = 1;
        _bottomBR = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topBR = wholeNumber;
        _bottomBR = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topBR = top;
        SetBottom(bottom);
    }

    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottomBR = bottom;
        }
        else
        {
            _bottomBR = 1;
        }
    }

    public void SetTop(int top)
    {
        _topBR = top;
    }

    public int GetTop()
    {
        return _topBR;
    }
    public int GetBottom()
    {
        return _bottomBR;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_topBR}/{_bottomBR}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_topBR / (double)_bottomBR;
    }
}