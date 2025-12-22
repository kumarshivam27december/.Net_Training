class Problem25
{
    public static void Solve()
    {
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());
        

        bool prime = true;

        for(int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                prime = false;
            }
        }

        if (prime == true)
        {
            System.Console.WriteLine("it is prime number");
        }
        else
        {
            System.Console.WriteLine("it is not a prime number");
        }
    }
}