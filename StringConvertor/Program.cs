using System;
class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine() ?? "";
        int number = Convert.ToInt32(Console.ReadLine());

        StringConvertor stringConvertor = new StringConvertor();

        // string tolower = stringConvertor.ConvertString(input);
        // Console.WriteLine($"{tolower}");


        // string tolowerbool = stringConvertor.ConvertString(input,true);
        // Console.WriteLine($"{tolowerbool}");

        string output = stringConvertor.ConvertString(input,number);
        Console.WriteLine($"{output}");
        
    }
}