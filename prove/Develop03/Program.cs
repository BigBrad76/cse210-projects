using System;
using System.Collections.Generic;

// ===================================================================================
// CREATIVITY AND EXCEEDING REQUIREMENTS SHOWCASE:
// 1. Smart Hiding Optimization: The `HideRandomWords` method specifically filters 
//    for words that are not already hidden before choosing items at random. This 
//    prevents the program from repeatedly trying to hide already hidden text 
//    at the end of the simulation, ensuring a crisp user experience.
// 2. Multi-Scripture Library: Instead of hardcoding a single option, the program
//    holds a repository/library list of scriptures and picks a random passage 
//    every time the application loads to surprise the student.
// ===================================================================================

class Program
{
    static void Main(string[] args)
    {
        // Creating a small library list of scriptures for the stretch challenge
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me")
        };

        // Select a random scripture from our library
        Random random = new Random();
        Scripture activeScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

// Main game loop
while (true)
{
    Console.Clear();
    Console.WriteLine(activeScripture.GetDisplayText());
    Console.WriteLine();

    // Check if it's completely hidden BEFORE asking them to press Enter again
    if (activeScripture.IsCompletelyHidden())
    {
        Console.WriteLine("Excellent work! You've hidden the whole passage.");
        break;
    }

    Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
    string input = Console.ReadLine();

    if (input.Trim().ToLower() == "quit")
    {
        break;
    }

    // Hide 3 words at a time
    activeScripture.HideRandomWords(3);
            }
        }
    }
