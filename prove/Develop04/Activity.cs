using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public abstract class Activity
    {
        // Protected attributes allow derived classes direct access while remaining encapsulated from the outside
        protected string _nameBR;
        protected string _descriptionBR;
        protected int _durationBR;

        public Activity(string name, string description)
        {
            _nameBR = name;
            _descriptionBR = description;
        }

        // Shared Behavior: Common Starting Message
        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_nameBR}.\n");
            Console.WriteLine(_descriptionBR);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            
            while (!int.TryParse(Console.ReadLine(), out _durationBR) || _durationBR <= 0)
            {
                Console.Write("Please enter a valid positive number of seconds: ");
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        // Shared Behavior: Common Ending Message
        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed another {_durationBR} seconds of the {_nameBR}.");
            ShowSpinner(3);
        }

        // Shared Behavior: Pausing/Animation (Spinner)
        protected void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b"); // Backspace mechanism to overwrite characters
                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
        }

        // Shared Behavior: Pausing/Animation (Countdown)
        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        // Abstract method ensures every subclass implements its unique functionality
        public abstract void Run();
    }
}