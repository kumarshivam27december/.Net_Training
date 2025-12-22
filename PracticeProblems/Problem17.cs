class Problem17
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        int i = 1;
        while (i <= n)
        {
            System.Console.WriteLine($"{i}");
            i++;
        }
    }
}