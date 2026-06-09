using System;
using System.Collections.Generic;

namespace Develop04
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you went out of your way to help someone"
        };

        private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // Trackers to satisfy "Exceeding Requirements" by guaranteeing item uniqueness
        private List<string> _unusedPrompts = new List<string>();
        private List<string> _unusedQuestions = new List<string>();
        private Random _random = new Random();

        public ReflectionActivity() : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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

        private string GetUniqueQuestion()
        {
            if (_unusedQuestions.Count == 0)
            {
                _unusedQuestions = new List<string>(_questions);
            }
            int index = _random.Next(_unusedQuestions.Count);
            string question = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);
            return question;
        }

        public override void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($"--- {GetUniquePrompt()} ---\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_durationBR);

            while (DateTime.Now < endTime)
            {
                Console.Write($"> {GetUniqueQuestion()} ");
                ShowSpinner(5); // Show spinner animation while pausing for reflection
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}