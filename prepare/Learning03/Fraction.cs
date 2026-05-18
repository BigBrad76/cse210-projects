using System;

public class FractionBR
{
    private int _topBR;
    private int _bottomBR;

    public FractionBR()
    {
        // Default to 1/1
        _topBR = 1;
        _bottomBR = 1;
    }

    public FractionBR(int wholeNumberBR)
    {
        _topBR = wholeNumberBR;
        _bottomBR = 1;
    }

    public FractionBR(int topBR, int bottomBR)
    {
        _topBR = topBR;
        SetBottomBR(bottomBR);
    }

    public void SetBottomBR(int bottomBR)
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

    public void SetTopBR(int topBR)
    {
        _topBR = topBR;
    }

    public int GetTopBR()
    {
        return _topBR;
    }
    public int GetBottomBR()
    {
        return _bottomBR;
    }

    public string GetFractionStringBR()
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