using System;

/*
=========================================================================================
Bradly Ruiz 
9 july 2026
Sources: That were used are Gemini and Microsoft Learn: Inheritance in C# and .NET,
Microsoft Learn: Polymorphism in C#, Microsoft Learn: DateTime Struct, Microsoft Learn: Thread.Sleep Method
Microsoft Learn: Character escape sequences in C#, Microsoft Learn: List Class, and Microsoft Learn: Random Class
========================================================================================
CREATIVITY AND EXCEEDING REQUIREMENTS DISCLOSURE:
1. Enhanced Pool Customization & Uniqueness: To exceed the base requirements, I engineered 
   a random-pull state tracker (_unusedPrompts and _unusedQuestions) inside both 
   ReflectionActivity and ListingActivity. This architecture prevents random prompts/questions 
   from repeating inside a single selection cycle. The list dynamically refreshes itself 
   only when all unique elements have been exhausted.
2. Defensive Programming Input Safeguards: Enhanced the application menu and duration setups 
   with rigorous verification logic (e.g., int.TryParse checks) preventing program errors 
   or crashes from invalid alphanumeric types or negative boundary inputs.
========================================================================================
*/

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflection activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case "2":
                        ReflectionActivity reflection = new ReflectionActivity();
                        reflection.Run();
                        break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}