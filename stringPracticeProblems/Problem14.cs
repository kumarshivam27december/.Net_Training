/*

57)program to compare 2 strings without using standard library functions   

*/

class Problem14
{
    public static void Solve()
    {
        string str1 = "Hello";
        string str2 = "Hello";

        bool equal = true;
        if (str1.Length != str2.Length)
        {
            equal = false;
        }
        for(int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                equal = false;
                break;
            }
        }

        if (equal)
        {
            Console.WriteLine("string are equal");
        }
        else
        {
            Console.WriteLine("no they not equal");
        }
    }
}