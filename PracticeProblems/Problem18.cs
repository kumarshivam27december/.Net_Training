class Problem18
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine($"{i}");
            }
            i++;
        }
    }
}