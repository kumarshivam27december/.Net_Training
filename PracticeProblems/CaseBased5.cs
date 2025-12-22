class CaseBased5
{
    public static void Solve()
    {
        int num;
        num = Convert.ToInt32(System.Console.ReadLine());
        int sum = 0;
        for(int i = 1; i <= num; i++)
        {
            sum+=i;
        }
        System.Console.WriteLine($"The sum of {num} natural number is {sum}");
    }
}