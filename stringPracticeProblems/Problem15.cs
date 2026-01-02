/*

58)program to concatenate 2 strings  using standard library functions 


*/

class Problem15
{
    public static void Solve()
    {
        string str1 = "hello";
        string str2 = "world";
        str1 = String.Concat(str1,str2);
        Console.WriteLine(str1);
    }
}