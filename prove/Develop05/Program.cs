using System;
// CREATIVITY & EXCEEDING REQUIREMENTS DOCUMENTATION:
// 1. Implemented a dynamic leveling system inside the GoalManager. A user's rank/level automatically updates 
//    and displays continuously on screen for every 1000 points earned.
// 2. Added defensive validation loops and system checks (e.g., File.Exists) to guarantee runtime safety 
//    during parsing and loading configurations.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
