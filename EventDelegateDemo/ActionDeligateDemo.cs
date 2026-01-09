class ActionDeligateDemo
{
    private static int result;
    public static void Solve()
    {
        Action<int,int> Addition = AddNumbers;
        Addition(10,20);
        Console.WriteLine($"Addition = {result}");
    }

    private static void AddNumbers(int param1,int param2)
    {
        result = param1+param2;
    }
}