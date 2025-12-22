class Problem9
{
    public static void Solve()
    {
        int number;
        System.Console.WriteLine("Enter a number any number : ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            System.Console.WriteLine("Your number is a positive number");
        }else if (number < 0)
        {
            System.Console.WriteLine("Your number is a negative number");
        }
        else
        {
            System.Console.WriteLine("Your number is 0");
        }
    }
}