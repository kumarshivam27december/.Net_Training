/*



53) program to reverse the contents of a string without using 
string function     


*/

class Problem10
{
    public static void Solve()
    {
        string str = "hello";
        string output = "";

        for(int i = str.Length - 1; i >= 0; i--)
        {
            output+=(str[i]);
        }

        Console.WriteLine(output);

    }
}