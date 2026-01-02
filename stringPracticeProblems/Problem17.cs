/*

60)program  to search a string in main string 

*/

class Problem17
{
    public static void Solve()
    {
        string mainstring = "hello world welcome to coding !";

        string str = "coding";

        if (mainstring.Contains(str))
        {
            Console.WriteLine("it is present");
        }
        else
        {
            Console.WriteLine("it is not present");
        }
    }
}