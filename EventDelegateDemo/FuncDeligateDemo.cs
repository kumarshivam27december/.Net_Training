class FuncDeligateDemo
{
     private static int AddNumbers(int a,int b)
    {
        return a+b;
    }
    public static void Solve()
    {
        Func<int,int,int> Addition = AddNumbers;
        int result =  Addition(10,20);
        Console.WriteLine(result);
    }
}