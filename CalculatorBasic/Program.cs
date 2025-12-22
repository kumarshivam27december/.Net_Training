using System;
class Program
{

    int number1;
    int number2;
    int output;
    public static void Main(string[] args)
    {
        // Program program = new Program();
        // int choice;
        // Console.WriteLine("Select option from Following List");
        // Console.WriteLine("1 For Addition");
        // Console.WriteLine("2 For Subtraction");
        // Console.WriteLine("3 For Multiplication");
        // Console.WriteLine("4 For Division");
        // Console.WriteLine("5 For Remainder");
        // Console.WriteLine("6 For Exit");

        // choice = Convert.ToInt32(Console.ReadLine());
        // switch (choice)
        // {
        //     case 1 : program.Add();
        //     break;
        //     case 2: program.Subtract();
        //     break;
        //     case 3 : program.Multiply();
        //     break;
        //     case 4: program.Divide();
        //     break;
        //     case 5 : program.Remainder();
        //     break;
        //     case 6: return;
        //     default : Console.WriteLine("Invalid Choice Enter choice between 1 to 6");
        //     break;

        // }



        LoopLearning.Loops();

    }
    public void Add()
    {
        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        output = number1+number2;

        Console.Write("The sum of {0} and {1} is {2}",number1,number2,output);

    }

    public void Subtract()
    {
        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        output = number1-number2;

        Console.Write("The difference of {0} and {1} is {2}",number1,number2,output);
    }

    public void Multiply()
    {
        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        output = number1*number2;
        Console.Write("The Multiplication of {0} and {1} is {2}",number1,number2,output);
    }

    public void Divide()
    {
        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        output = number1/number2;

        Console.Write("The division of {0} and {1} is {2}",number1,number2,output);

    }


    public void Remainder()
    {
        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        output = number1 %number2;

        Console.Write($"The remainder of {number1} and {number1} is {output}");

    }


}



