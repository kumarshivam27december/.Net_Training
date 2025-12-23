using System;
class Calculator
{
    // int _num1;
    // int _num2;
    // int _num3;

    // public int Num1
    // {
    //     get{
    //         return _num1;
    //     }
    //     set{
    //         _num1 = value;
    //     }
    // }

    //     public int Num2
    // {
    //     get{
    //         return _num2;
    //     }
    //     set{
    //         _num2 = value;
    //     }
    // }


    //     public int Num3
    // {
    //     get{
    //         return _num3;
    //     }
    //     set{
    //         _num3 = value;
    //     }
    // }
    public  int  Number1 { get; set; }
    public int Number2 { get; set; }
    public int Result { get; set; }


    public Calculator()
    {
        Console.WriteLine("This is a default constructor");
    }

    public Calculator(int Number1,int Number2)
    {
        this.Number1 = Number1;
        this.Number2 = Number2;
        Console.WriteLine("This is a parametrised constructor");
    }

    public int Add(int number1 ,int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = number1+ number2;
        return Result;
    }

    public int subtract()
    {
        Result = Number1 - Number2;
        return Result;
    }

    public int Multipy(int number1,int number2)
    {
        Number1 = number1;
        Number2 = number2;
        Result = Number1*Number2;
        return Result;
    }

    public void Divide()
    {
        Result = Number1/Number2;
        Console.WriteLine($"Division is {Result}");
    }

    public void Swap(int number1,int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }


    public void Swap1(ref int number1,ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;
    }

    public void Addition(int number1,int number2,out int result, out int marks1,out int marks2)
    {
        result  = number1+number2;
        marks1 = number1;
        marks2 = number2;
    }



}