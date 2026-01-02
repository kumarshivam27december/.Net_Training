/*


55) program to convert a string to uppercase and lowercase without 
using string functions
HINT:
lowerletter-32=UPPERLETTER;
UPPERLETTER+32=lowerletter;

*/
class Problem12
{
    public static void Solve()
    {
        string str = "HelloWorld";
        Console.WriteLine("To upper letter");
        

        string upperstr = "";
        for(int i = str.Length - 1; i >= 0; i--)
        {
            upperstr+=(str[i]-32);
        }
        Console.WriteLine(upperstr);


        Console.WriteLine("To lower letter");
        string lowerstr = "";

        for(int i = str.Length - 1; i >= 0; i--)
        {
            lowerstr+=(str[i]+32);
        }
        Console.WriteLine(lowerstr);
    }
}

