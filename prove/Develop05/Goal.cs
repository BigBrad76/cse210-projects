using System;

public abstract class Goal
{
    protected string _shortNameBR;
    protected string _descriptionBR;
    protected int _pointsBR;

    public Goal(string name, string description, int points)
    {
        _shortNameBR = name;
        _descriptionBR = description;
        _pointsBR = points;
    }

    // Abstract methods must be overridden by child classes
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // Virtual method can be overridden, but has a default setup
    public virtual string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        return $"[{statusSymbol}] {_shortNameBR} ({_descriptionBR})";
    }
}