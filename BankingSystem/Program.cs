class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        int sum = calculator.Addition(20,10);
        Console.WriteLine($"The sum is {sum} ");

        Calculator calculator1 = new Calculator(30,10);
        int sub = calculator1.Subtraction();
        Console.WriteLine($"the subtraction is {sub}");

        int mul = calculator1.Multiplication();
        Console.WriteLine($"the multiplication is {mul}");

        calculator1.Division();
    }
}