public class PromptGeneratorBR
{
    public List<string> _promptsBR = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What is a piece of advice you constantly give to others, but struggle to follow yourself?",
        "What was the strongest emotion I felt today and why?",
        "If you knew you couldn't fail for the next 24 hours, what is the first thing you would do?",
        "What is one thing I am grateful for right now?",
        "If you had wings where would you fly to first?",
        "If you had a 100 bucks whats the frist thing you would buy?",
    };

    public string GetRandomPromptBR()
    {
        Random randomBR = new Random();
        int index = randomBR.Next(_promptsBR.Count);
        return _promptsBR[index];
    }
}