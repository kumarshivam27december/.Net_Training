public class Program
{
    public delegate double ArithmeticOperation(double number1,double number2);

    public static double Add(double number1,double number2)
    {
        return number1+number2;
    }
    public static double Subtract(double number1,double number2)
    {
        return number1-number2;
    }

    public static double Multiply(double number1,double number2)
    {
        return number1*number2;
    }

    public static double Divide(double number1,double number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero");
        }

        double output = 0;
        output = number1/number2;
        return output;
    }

    public static double PerformOperation(ArithmeticOperation operation,double number1,double number2)
    {
        return operation(number1,number2);
    }
    public static void Main()
    {
        try
        {
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            string operationInput = Console.ReadLine() ?? "";
            operationInput=operationInput.ToLower();

            ArithmeticOperation operation = null;
            switch (operationInput)
            {
                case "add":
                    operation = Add;
                    break;
                case "subtract":
                    operation = Subtract;
                    break;
                case "multiply":
                    operation = Multiply;
                    break;
                case "divide":
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    return;
            }

            double result = PerformOperation(operation,number1,number2);
            Console.WriteLine($"The result is {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed");
        }catch(FormatException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

}
