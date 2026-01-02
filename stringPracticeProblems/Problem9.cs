/*

52) program to reverse the contents of a string using string function     


*/

class Problem9
{
    public static void Solve()
    {
        string str = "Hello";
        string output = new string(str.Reverse().ToArray());
        Console.WriteLine(output);
    }
}