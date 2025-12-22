class Problem4
{
    public static void Solve()
    {
        System.Console.WriteLine("Please Enter your name");
        string name;
        name = System.Console.ReadLine() ?? "";//it was showing warning if the string become empty 
        System.Console.WriteLine($"welcome {name}");
    }
}