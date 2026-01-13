public class Program
{
    public static void Main(string[] args)
    {
        string operation = Console.ReadLine() ?? "";
        operation = operation.ToLower();
        string inputstring = Console.ReadLine() ?? "";

        Action<string> PrintReverseString = ReverseString;
        Func<string, bool> ispalindrome = CheckPalindrome;


        if (operation == "reverse")
        {
            PrintReverseString(inputstring);
        }
        else if (operation == "palindrome")
        {
            bool result = ispalindrome(inputstring);
            Console.WriteLine("Is palindrome: "+result);
        }
        else
        {
            Console.WriteLine("Invalid operation");
        }

    }
    static void ReverseString(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        string reverseString = new string(chars);
        Console.WriteLine("Reversed string is " + reverseString);
    }

    static bool CheckPalindrome(string str)
    {
        string lowerstring = str.ToLower();
        char[] chars = lowerstring.ToCharArray();
        Array.Reverse(chars);
        string reverseString = new string(chars);
        return reverseString == lowerstring;
    }
}