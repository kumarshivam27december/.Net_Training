class Program
{
    public static void Main(string[] args)
    {
        /*
        //calling new constructor as default constructor
        // Calculator calculator = new Calculator();
        
        // int num1 = 10;
        // int num2 = 20;
        // int sum = calculator.Add(num1,num2);
        // Console.WriteLine($"Sum of the number {num1} and {num2} is {sum}");

        // int subtract = calculator.Subtract();
        // Console.WriteLine($"subtraction of two number is {subtract}");

        //calling new calculator as parameterized constructor
        Calculator calculator1 = new Calculator(30,10);

        // calculator1.Multiplication(30,2);
        calculator1.Divide();


        // Calculator calculator2 = new Calculator();

        // //call by value
        // int number1 = 30;
        // int number2 = 20;
        // Console.WriteLine($"Before swapping {number1} and {number2} ");
        // calculator2.Swap(number1,number2);
        // Console.WriteLine($"After swapping {number1} {number2}");

        //call by reference
        // int number3 = 30;
        // int number4 = 20;

        // Console.WriteLine($"Before swapping {number3} and {number4} ");
        // calculator2.Swap1(ref number3, ref number4);
        // Console.WriteLine($"After swapping {number3} {number4}");

        // Calculator calculator3 = new Calculator();
        // int number5 = 59;
        // int number6 = 10;
        // int result ;
        // int outputNum1 ;
        // int outputNum2 ;

        // calculator3.Addition(number5, number6, out result, out outputNum1, out  outputNum2);

        // Console.WriteLine($"First number {outputNum1} second number is {outputNum2} Addition result is {result}");
    
  
        */

        StaticInstanceDemo demo = new StaticInstanceDemo();
        demo.InstanceCount();
        demo.InstanceCount();

        Console.WriteLine($"demo instance variable is {demo.InstanceDisplay()}");
        Console.WriteLine($"demo static variable is {StaticInstanceDemo.StaticDisplay()}");

        StaticInstanceDemo demo1 = new StaticInstanceDemo();
        demo1.InstanceCount();

        Console.WriteLine($"demo instance variable is {demo1.InstanceDisplay()}");
        Console.WriteLine($"demo static variable is {StaticInstanceDemo.StaticDisplay()}");
        
        StaticInstanceDemo demo2 = new StaticInstanceDemo();
        StaticInstanceDemo.StaticCount();
        StaticInstanceDemo.StaticCount();

        Console.WriteLine($"static var after increment = "+StaticInstanceDemo.StaticDisplay());       
        
    }
}