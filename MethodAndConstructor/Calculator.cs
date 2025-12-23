using System.ComponentModel;

class Calculator
{
    //  int num1;
    //  int num2;
    //  int result;
    //  public int Num1
    // {
    //     get
    //     {
    //         return num1;
    //     }
    //     set
    //     {
    //         num1 = value;
    //     }
    // }
    // public int Num2
    // {
    //     get
    //     {
    //         return num2;
    //     }
    //     set
    //     {
    //         num2 = value;
    //     }
    // }public int Result
    // {
    //     get
    //     {
    //         return result;
    //     }
    //     set
    //     {
    //         result = value;
    //     }
    // }

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

    /*
    method with paratmeter with return type
    method without parameter with return type
    method with parameter without return type
    method without parameter and without type
    */

    //method with paratmeter with return type

    public int Add(int number1,int number2)
    {
        Num1 = number1;
        Num2 = number2;
        Result = Num1+ Num2;
        return Result;
    }

    //method without parameter with return type


    public int Subtract()
    {
        Num1 = 30;
        Num2 = 20;
        Result = Num1-Num2;
        return Result;
    }

    //method with parameter without return type

    public void Multiplication(int number1,int number2)
    {
        Num1 = number1;
        Num2 = number2;

        Result = Num1*Num2;

        Console.WriteLine($"Multiplication of {number1} and {number2} is {Result}");
    }

    //method without return type without parameter
    public void Divide()
    {
        Result = Num1 / Num2;
        Console.WriteLine($"Division of the two numbers {Num1} and {Num2} is {Result}");
    }



    public void Swap(int number1,int number2)
    {
        int tempVariable1 = number1;
        int tempVariable2 = number2;
        int temp = 0;


        Console.WriteLine($"Before Swaping {tempVariable1} {tempVariable2}");
        temp   = tempVariable1;
        tempVariable1 = tempVariable2;
        tempVariable2 = temp;
        Console.WriteLine($"After Swapping {tempVariable1}  {tempVariable2}");
    }

    //inout parameter passby reference
     public void Swap1(ref int number1, ref int number2)
    {
       int temp = 0;
       temp = number1;
       number1 = number2;
       number2 = temp;
    }

    public void Addition(int number1,int number2,out int result,out int number3 ,out int number4)
    {
        result = number1+number2;
        number3 = number1;
        number4 = number2;
    }


}