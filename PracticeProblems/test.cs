class Test
{
    public static void Solve()
    {
        int num1, num2, num3;

        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("Largest number is: " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("Largest number is: " + num2);
        }
        else
        {
            Console.WriteLine("Largest number is: " + num3);
        }
    }
}