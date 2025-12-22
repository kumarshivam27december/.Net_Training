class Problem19
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        int i = 1;
        int sum = 0;
        while (i <= n)
        {
            sum+=i;
            i++;
        }
        System.Console.WriteLine($"the sum from 1 to {n} is {sum}");
    }
}