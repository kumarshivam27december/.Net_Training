using System;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("Enter input 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter input 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int sum = calculator.Add(number1,number2);
        Console.WriteLine($"The sum is {sum}");
        int multi = calculator.Multipy(number1,number2);
        Console.WriteLine($"The multiplication is {multi}");

        Calculator calculator1 = new Calculator(79,10);
        int sub = calculator1.subtract();
        calculator1.Divide();


        Console.WriteLine("call by value");
        Console.WriteLine($"before swapping {number1} {number2}");
        calculator1.Swap(number1,number2);
        Console.WriteLine($"after swapping {number1} {number2}");


        Console.WriteLine("call by reference");
        Console.WriteLine($"before swapping {number1} {number2}");
        calculator1.Swap(number1,number2);
        Console.WriteLine($"after swapping {number1} {number2}");

        int result;
        int marks1;
        int marks2;

        calculator.Addition(number1,number2,out result,out marks1,out marks2);
        Console.WriteLine($"the addition of {number1 } + {number2} is {result} and marks are {marks1} and {marks2} ");

    }
}