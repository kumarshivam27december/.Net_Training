class Problem30
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        
        int sum = 0;
        for(int i = 1; i < n; i++)
        {
            if(i%3==0 || i % 5 == 0)
            {
                sum+=i;
            }
        }

        System.Console.WriteLine($"sum from all number which are divisible by  3 or 5 from 1 to {n} is {sum}");
    }
}