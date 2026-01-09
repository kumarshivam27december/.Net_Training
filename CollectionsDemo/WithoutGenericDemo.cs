using System.Collections;
class WithoutGenericDemo
{
    public static void Demo()
    {
        Console.WriteLine("Without Generic Class");

        AddClass addClass = new AddClass();
        int sumInt = addClass.AddInt(50,19);
        Console.WriteLine($"Sum of integer is {sumInt}");

        float sumFloat = addClass.AddFloat(49.09f,19.91f);
        Console.WriteLine($"Sum of float is {sumFloat}");

        string concat = addClass.AddString("Sixty ","Nine");
        Console.WriteLine($"Sum of string is {concat}");

        Console.WriteLine();
        Console.WriteLine();
    }
}