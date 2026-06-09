using System;
using System.Collections.Generic;

namespace Develop04
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt peace or inspiration this month?",
            "Who are some of your personal heroes?"
        };

        private List<string> _unusedPrompts = new List<string>();
        private Random _random = new Random();

        public ListingActivity() : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        private string GetUniquePrompt()
        {
            if (_unusedPrompts.Count == 0)
            {
                _unusedPrompts = new List<string>(_prompts);
            }
            int index = _random.Next(_unusedPrompts.Count);
            string prompt = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return prompt;
        }

        public override void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("List as many items as you can to the following prompt:");
            Console.WriteLine($"--- {GetUniquePrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();

            int count = 0;
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            // Allows entry loop until duration time expires
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    count++;
                }
            }

            Console.WriteLine($"You listed {count} items!");
            DisplayEndingMessage();
        }
    }
}