using System.IO;

public class JournalBR
{
    public List<EntryBR> _entriesBR = new List<EntryBR>();

    public void AddEntryBR(EntryBR newEntry)
    {
        _entriesBR.Add(newEntry);
    }

    public void DisplayAllBR()
    {
        if (_entriesBR.Count == 0)
        {
            Console.WriteLine("\n*** Your journal is currently empty. Start writing! ***");
            return;
        }
        foreach (EntryBR entry in _entriesBR)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileBR)
    {
        using (StreamWriter outputFile = new StreamWriter(fileBR))
        {
            foreach (EntryBR entry in _entriesBR)
            {
                // Adding the daily goal to the file storage string
                outputFile.WriteLine($"The date was {entry._dateBR}. Prompt answer was {entry._promptTextBR}. Your entry was{entry._entryTextBR}. My Mood was{entry._moodBR}. Your daily goals was{entry._dailyGoalBR}.");
            }
        }
    }

    public void LoadFromFileBR(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("\n[!] Error: That file doesn't exist yet.");
            return;
        }

        _entriesBR.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 5)
            {
                EntryBR entry = new EntryBR();
                entry._dateBR = parts[0];
                entry._promptTextBR = parts[1];
                entry._entryTextBR = parts[2];
                entry._moodBR = parts[3];
                entry._dailyGoalBR = parts[4];
                _entriesBR.Add(entry);
            }
        }
    }
}