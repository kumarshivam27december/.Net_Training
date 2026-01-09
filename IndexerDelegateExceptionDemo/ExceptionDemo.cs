class ExceptionDemo
{
    public static void Demo()
    {
        int num1 = 0;
        int num2 = 0;
        int result = 0;

        int[] arr = new int[6] { 10, 20, 30, 40, 50, 60 };
        try
        {
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 / num2;

            try
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"this is index out of bound custom +{ex.Message.ToString()}");
            }
            finally
            {
                Console.WriteLine("code executed");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero exception + {ex.Message.ToString()}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid Format {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"this is {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Result of {num1} / {num2} is {result}");

        }
        Console.WriteLine($"Result of {num1} / {num2} is {result}");

    }
}