class Problem22
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        int a = 0;
        int b = 1;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        for(int c = 1; c <= n; c++)
        {
            int temp = a+b;
            System.Console.WriteLine($"{temp}");
            a = b;
            b = temp;
        }
    }
}