class Problem24
{
    public static bool check(int n)
    {
        //len check
        int temp1 = n;
        int len = 0;
        while (temp1 > 0)
        {
            len++;
            temp1/=10;
        }



        int number = n;
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
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Solve()
    {
        int n1;
        System.Console.WriteLine("enter a number");
        n1 = Convert.ToInt32(System.Console.ReadLine());

        int n2;
        System.Console.WriteLine("enter a number");
        n2 = Convert.ToInt32(System.Console.ReadLine());



        for(int i = n1; i <= n2; i++)
        {
            if (check(i) == true)
            {
                System.Console.WriteLine($"{i} is armstrong");
            }
        }
    }
}