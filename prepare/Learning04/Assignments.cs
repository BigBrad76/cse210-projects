public class Assignment
{
    private string _studentNameBR;
    private string _topicBR;

    public Assignment(string studentName, string topic)
    {
        _studentNameBR = studentName;
        _topicBR = topic;
    }

    // We will provide Getters for our private member variables so they can be accessed
    // later both outside the class as well is in derived classes.
    public string GetStudentName()
    {
        return _studentNameBR;
    }

    public string GetTopic()
    {
        return _topicBR;
    }

    public string GetSummary()
    {
        return _studentNameBR + " - " + _topicBR;
    }
}