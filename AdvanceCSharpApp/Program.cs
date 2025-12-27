using System;
namespace CalculatorApp
{
    //declaration of delegate
    public delegate int CalculatorDelegate(int num1,int num2);
    class Program
    {
        public static void Main(string[] args)
        {
            //instantilizing the delegate
            Calculator calculator = new Calculator();
            CalculatorDelegate calculateAdd= new CalculatorDelegate(calculator.Add);
            CalculatorDelegate calculateSub= new CalculatorDelegate(calculator.Subtract);
            CalculatorDelegate calculateMul= new CalculatorDelegate(calculator.Multiplication);
            CalculatorDelegate calculateDiv= new CalculatorDelegate(calculator.Division);

            //callinng the delegate -> single cast delegate
            int sum = calculateAdd(20,49);
            Console.WriteLine($"Sum of two number is {sum}");
            int diff = calculateSub(10,9);
            Console.WriteLine($"diff of two number is {diff}");
            int mul = calculateMul(45,2);
            Console.WriteLine($"multiplication of two number is {mul}");
            int div = calculateDiv(20,2);
            Console.WriteLine($"division of two number is {div}");

            //multicast 
            CalculatorDelegate calcmulticast;
            calcmulticast = calculateAdd;
            calcmulticast += calculateSub;
            calcmulticast += calculateMul;
            calcmulticast += calculateDiv;
            Console.WriteLine("calling the multicaset comment {0}",calcmulticast(30,3));
            
        }
    }
}