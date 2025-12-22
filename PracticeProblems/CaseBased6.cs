class CaseBased6
{
    public static void Solve()
    {
        int num;
        num = Convert.ToInt32(System.Console.ReadLine());
        int cnt = 0;
        System.Console.WriteLine($"First {num} even numbers:");
        for(int i = 2; i <= Int32.MaxValue; i += 2)
        {
            if (cnt == num)
            {
                break;
            }
            else
            {
                System.Console.WriteLine($"{i}");
            }
            cnt++;
        }

        
    }
}