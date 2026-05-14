public class EntryBR
{
    public string _dateBR;
    public string _promptTextBR;
    public string _entryTextBR;
    public string _moodBR;
    public string _dailyGoalBR;

    public void Display()
    {
        // Using distinct colors for different parts of the entry
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n[ ENTRY DATE: {_dateBR} ]");
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Prompt:  {_promptTextBR}");
        
        Console.ResetColor();
        Console.WriteLine($"Mood:    {_moodBR}");
        Console.WriteLine($"Goal:    {_dailyGoalBR}");
        Console.WriteLine($"Reflect: {_entryTextBR}");
        Console.WriteLine(new string('═', 45)); // Creates a double-line separator
    }
}