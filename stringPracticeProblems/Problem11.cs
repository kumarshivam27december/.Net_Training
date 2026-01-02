/*


54)program to convert from lowerletter to upperletter and vise versa
 lowerletter-32=UPPERLETTER;
 UPPERLETTER+32=lowerletter;
    
*/

class Problem11
{
    public static void Solve()
    {
        string str = "helloworld";
        Console.WriteLine("To upper letter");
        str = str.ToUpper();
        Console.WriteLine(str);


        Console.WriteLine("To lower letter");
        str = str.ToLower();
        Console.WriteLine(str);
    }
}