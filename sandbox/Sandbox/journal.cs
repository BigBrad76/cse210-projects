// The user of this class doesn't need to see the logic below.
// They only need to know that 'SaveToFile' exists.
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // ABSTRACTION IN ACTION:
    // This method abstracts the complex logic of File I/O.
    public void SaveToFile(string fileName)
    {
        // The implementation details (using, StreamWriter, loops, delimiters)
        // are hidden from the rest of the program.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
}

// In Program.cs, we see the simplified "Interface"
class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        // The Main method uses abstraction to save the file in one simple line:
        myJournal.SaveToFile("journal.txt");
    }
}