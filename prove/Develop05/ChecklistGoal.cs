public class ChecklistGoal : Goal
{
    private int _amountCompletedBR;
    private int _targetBR;
    private int _bonusBR;

    // Constructor for creating a brand new checklist goal
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompletedBR = 0;
        _targetBR = target;
        _bonusBR = bonus;
    }

    // Constructor used when loading an existing checklist goal
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompletedBR = amountCompleted;
        _targetBR = target;
        _bonusBR = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompletedBR < _targetBR)
        {
            _amountCompletedBR++;
            if (_amountCompletedBR == _targetBR)
            {
                return _pointsBR + _bonusBR; // Give base points + milestone bonus
            }
            return _pointsBR;
        }
        return 0;
    }

    public override bool IsComplete() => _amountCompletedBR >= _targetBR;

    public override string GetDetailsString()
    {
        string statusSymbol = IsComplete() ? "X" : " ";
        return $"[{statusSymbol}] {_shortNameBR} ({_descriptionBR}) -- Currently completed: {_amountCompletedBR}/{_targetBR}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortNameBR},{_descriptionBR},{_pointsBR},{_amountCompletedBR},{_targetBR},{_bonusBR}";
    }
}