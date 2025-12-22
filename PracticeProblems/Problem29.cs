class Problem29
{
    public static void Solve()
    {
        int n1;
        System.Console.WriteLine("enter start number");
        n1 = Convert.ToInt32(System.Console.ReadLine());

        int n2;
        System.Console.WriteLine("enter end number");
        n2 = Convert.ToInt32(System.Console.ReadLine());


        for(int i = n1; i <= n2; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine($"{i}");
            }
        }

    }
}