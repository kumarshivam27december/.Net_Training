using System;
using System.Net.WebSockets;
class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int number1 = 34;
        int number2 = 35;
        int result;
        int marks1;
        int marks2;
        calculator.Addition(number1,number2,out result,out marks1,out marks2);
        Console.WriteLine($"the sum is  {result} and marks are {marks1} {marks2}");
        
    }
}