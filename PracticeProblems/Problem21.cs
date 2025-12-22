class Problem21
{
    public static void Solve()
    {
        double n;
        double k;
        System.Console.WriteLine("enter a number");
        n = Convert.ToDouble(System.Console.ReadLine());
        System.Console.WriteLine("enter the value of power to calculate");
        k = Convert.ToDouble(System.Console.ReadLine());
        double output = Math.Pow(n,k);
        System.Console.WriteLine($"the value  is {output}");
    }
}