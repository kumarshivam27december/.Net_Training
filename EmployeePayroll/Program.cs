using System;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int number1 = 10;
        int number2 = 30;
        Console.WriteLine($"before swapping {number1} {number2}");
        calculator.Swap(number1,number2);
        Console.WriteLine($"before swapping {number1} {number2}");

    }
}