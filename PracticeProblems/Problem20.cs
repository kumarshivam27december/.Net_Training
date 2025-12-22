class Problem20
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        int i = 1;
        while (i <= 10)
        {
            System.Console.WriteLine($"{n} * {i} = {n*i}");
            i++;   
        }
    }
}