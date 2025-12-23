using System;
class Calculator
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }
    public int Result { get; set; }



    public Calculator()
    {
        
    }
    public Calculator(int Num1,int Num2)
    {
        this.Num1 = Num1;
        this.Num2 = Num2;
    }

    public int Addition(int number1,int number2)
    {
        Num1 = number1;
        Num2 = number2;
        Result = Num1+Num2;
        return Result;
    }

    public int Subtraction()
    {
        Result = Num1-Num2;
        return Result;   
    }

    public int Multiplication()
    {
        Result = Num1*Num2;
        return Result;
    }

    public void Division()
    {
        int temp1 = 100;
        int temp2 = 20;
        Result = temp1/temp2;
        Console.WriteLine($"the division of {temp1} and {temp2} is {Result}");
    }
}