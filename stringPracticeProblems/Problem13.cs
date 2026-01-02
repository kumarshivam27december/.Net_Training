/*


56)program to compare 2 strings  using standard library functions    


*/
class Problem13
{
    public static void Solve()
    {
        string str1 = "Hello";
        string str2 = "Hello1";

        if (str1.CompareTo(str2)==0)
        {
            Console.WriteLine("both are equal");
        }
        else
        {
            Console.WriteLine("They are not equal");
        }
    }
}