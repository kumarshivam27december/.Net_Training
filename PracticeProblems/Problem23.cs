class Problem23
{
    public static void Solve()
    {
        string n;
        System.Console.WriteLine("enter a number");
        n = System.Console.ReadLine() ?? "";
        int len = n.Length;

        int number = Convert.ToInt32(n);
        int temp = number;
        double value = 0;
        while (temp > 0)
        {
            int remainder = temp%10;
            value += Math.Pow(remainder,len);
            temp/=10;
        }

        if (value == number)
        {
            System.Console.WriteLine("it is an armstrong number");
        }
        else
        {
            System.Console.WriteLine("it is not an armstrong number");
        }
    }
}