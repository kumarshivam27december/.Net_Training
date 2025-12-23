using System;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int number1 = 69;
        int number2 = 96;
        Console.WriteLine($"Before swapping {number1} {number2}");
        calculator.Swap1(ref number1,ref number2);
        Console.WriteLine($"After swapping {number1} {number2}");
    }
}