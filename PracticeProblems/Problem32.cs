class Problem32
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        
        int temp = n;
        int sum = 0;
        while (temp > 0)
        {
            int remainder = temp%10;
            sum+=remainder;
            temp/=10;
        }

        System.Console.WriteLine($"sum of digits of {n} is {sum}");
    }
}