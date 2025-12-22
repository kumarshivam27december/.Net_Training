class Problem31
{
    public static void Solve()
    {
        for(int i = 1; i <= 100; i++)
        {
            if (i % 17 == 0)
            {
                System.Console.WriteLine($"{i} is multiple of 17");
            }
        }
    }
}