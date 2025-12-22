class Problem8
{
    public static void Solve()
    {
        int number1;
        int number2;
        System.Console.WriteLine("Enter input 1 : ");
        number1 = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Enter input 2 : ");
        number2 = Convert.ToInt32(System.Console.ReadLine());

        if (number1 > number2)
        {
            System.Console.WriteLine($"{number1} is greater than {number2}");
        }
        else if(number2>number1)
        {
            System.Console.WriteLine($"{number1} is less than {number2}");
        }
        else
        {
            System.Console.WriteLine("Both are equal");
        }

    }
}