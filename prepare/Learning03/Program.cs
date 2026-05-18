using System;
{
static void Main(string[] args)
    {
        FractionBR f1 = new FractionBR();
        Console.WriteLine(f1.GetFractionStringBR());
        Console.WriteLine(f1.GetDecimalValueBR());

        FractionBR f2 = new FractionBR(5);
        Console.WriteLine(f2.GetFractionStringBR());
        Console.WriteLine(f2.GetDecimalValueBR());

        FractionBR f3 = new FractionBR(3, 4);
        Console.WriteLine(f3.GetFractionStringBR());
        Console.WriteLine(f3.GetDecimalValueBR());

        FractionBR f4 = new FractionBR(1, 3);
        Console.WriteLine(f4.GetFractionStringBR());
        Console.WriteLine(f4.GetDecimalValueBR());

        Random random= new Random();
        FractionBR f5 = new FractionBR();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f5.SetTopBR(topValue);
            f5.SetBottomBR(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionStringBR()}");
            Console.WriteLine($" Number: {f5.GetDecimalValueBR()}");
        }
    }
}