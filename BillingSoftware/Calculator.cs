using System;
class Calculator
{
    public Calculator()
    {
        Console.WriteLine("this is default constructor");
    }


    public Calculator(string name)
    {
        Console.WriteLine($"this is a parameterised constructor {name}");
    }
    

}