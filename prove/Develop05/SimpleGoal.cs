public class SimpleGoal : Goal
{
    private bool _isCompleteBR;

    // Constructor for creating a brand new goal
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleteBR = false;
    }

    // Constructor used when loading an existing goal from a file
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isCompleteBR = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isCompleteBR)
        {
            _isCompleteBR = true;
            return _pointsBR;
        }
        return 0; // Already completed goals award no additional points
    }

    public override bool IsComplete() => _isCompleteBR;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortNameBR},{_descriptionBR},{_pointsBR},{_isCompleteBR}";
    }
}