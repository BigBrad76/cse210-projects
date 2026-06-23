using System;

// Parent Class (Superclass)
public class Character
{
    // Properties shared by all characters
    public string Name { get; set; }
    public int Health { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    // Method shared by all characters
    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} took {amount} damage! Remaining health: {Health}");
    }
}

// Child Class (Subclass) inheriting from Character using the ':' operator
public class Mage : Character
{
    // Unique property exclusive to the Mage class
    public int Mana { get; set; }

    // Constructor calls the parent constructor using 'base'
    public Mage(string name, int health, int mana) : base(name, health)
    {
        Mana = mana;
    }

    // Unique method exclusive to the Mage class
    public void CastSpell()
    {
        if (Mana >= 10)
        {
            Mana -= 10;
            Console.WriteLine($"{Name} casts a fireball! Mana left: {Mana}");
        }
        else
        {
            Console.WriteLine($"{Name} is out of mana!");
        }
    }
}

// --- Demonstration ---
class Program
{
    static void Main()
    {
        // Instantiate the derived Mage object
        Mage gandalf = new Mage("Gandalf", 100, 50);

        // 1. Calling the inherited method from the Character parent class
        gandalf.TakeDamage(20);

        // 2. Calling the unique method from the Mage child class
        gandalf.CastSpell();
    }
}