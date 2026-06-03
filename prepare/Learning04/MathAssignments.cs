public class MathAssignment : Assignment
{
    private string _textbookSectionBR;
    private string _problemsBR;

    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSectionBR = textbookSection;
        _problemsBR = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSectionBR} Problems {_problemsBR}";
    }
}