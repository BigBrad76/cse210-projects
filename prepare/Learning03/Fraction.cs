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

    public Fraction(int wholeNumberBR)
    {
        _topBR = wholeNumberBR;
        _bottomBR = 1;
    }

    public Fraction(int topBR, int bottomBR)
    {
        _topBR = topBR;
        SetBottom(bottomBR);
    }

    public void SetBottom(int bottomBR)
    {
        if (bottomBR != 0)
        {
            _bottomBR = bottomBR;
        }
        else
        {
            _bottomBR = 1;
        }
    }

    public void SetTop(int topBR)
    {
        _topBR = topBR;
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

    public double GetDecimalValueBR()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_topBR / (double)_bottomBR;
    }
}