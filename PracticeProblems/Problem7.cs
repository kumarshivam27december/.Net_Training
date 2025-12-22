class Problem7
{
    public static void Solve()
    {
        int number;
        System.Console.WriteLine("Enter the number");
        number = Convert.ToInt32(System.Console.ReadLine());

        if (number % 2 == 0)
        {
            System.Console.WriteLine("Your number is Even");
        }
        else
        {
            System.Console.WriteLine("Your number is Odd");
        }
    }
}