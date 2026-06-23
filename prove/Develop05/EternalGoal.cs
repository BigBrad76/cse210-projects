public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _pointsBR; // Keeps giving points indefinitely
    }

    public override bool IsComplete() => false; // Eternal goals are never complete

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortNameBR},{_descriptionBR},{_pointsBR}";
    }
}