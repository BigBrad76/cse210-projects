using System;
using System.Threading;

/* CREATIVITY DESCRIPTION:
1. PERSONALIZED TRACKING: Added a 'Daily Goal' field to each entry to encourage 
   forward-thinking alongside daily reflection.
2. MOOD LOGGING: Included a mood/energy level attribute for emotional data.
3. UI CUSTOMIZATION: Implemented custom ASCII borders, color-coded sections, 
   and a simulated 'syncing' delay for file saving to improve the user feel.
4. ERROR HANDLING: Added checks to prevent the program from crashing if a user 
   tries to load a file that doesn't exist.
*/

class Program
{
    static void Main(string[] args)
    {
        JournalBR theJournal = new JournalBR();
        PromptGeneratorBR promptGen = new PromptGeneratorBR();
        string choice = "";

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine("║      MY PERSONAL REFLECTION       ║");
        Console.WriteLine("╚═══════════════════════════════════╝");
        Console.ResetColor();

        while (choice != "5")
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1) Write a new page");
            Console.WriteLine("2) Read my journal");
            Console.WriteLine("3) Open a journal file");
            Console.WriteLine("4) Save current journal");
            Console.WriteLine("5) Close program");
            Console.Write("\nSelection > ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPromptBR();
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nPROMPT: {prompt}");
                Console.ResetColor();
                Console.Write("Your thoughts: ");
                string response = Console.ReadLine();

                Console.Write("Current Mood: ");
                string mood = Console.ReadLine();

                Console.Write("What was your main goal today? ");
                string goal = Console.ReadLine();

                EntryBR newEntry = new EntryBR();
                newEntry._dateBR = DateTime.Now.ToShortDateString();
                newEntry._promptTextBR = prompt;
                newEntry._entryTextBR = response;
                newEntry._moodBR = mood;
                newEntry._dailyGoalBR = goal;

                theJournal.AddEntryBR(newEntry);
                Console.WriteLine("\n[ Entry recorded. ]");
            }
            else if (choice == "2")
            {
                theJournal.DisplayAllBR();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename (e.g. journal.txt): ");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFileBR(loadFile);
                Console.WriteLine("Synchronizing files...");
                Thread.Sleep(500);
            }
            else if (choice == "4")
            {
                Console.Write("Name your save file: ");
                string saveFile = Console.ReadLine();
                
                Console.Write("Saving to cloud");
                for(int i=0; i<3; i++) { Console.Write("."); Thread.Sleep(300); }
                
                theJournal.SaveToFile(saveFile);
                Console.WriteLine("\nSuccess! Your data is secure.");
            }
        }

        Console.WriteLine("\nTake care of yourself. Goodbye!");
    }
}