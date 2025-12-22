


using System;
class SubtractNumber
{
    public static void  Sub()
    {
        int num1 ;
        int num2 ;
        //taking user input
        Console.Write("Enter First Number : ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.Write("Enter The Second Number : ");
        num2 = Int32.Parse(Console.ReadLine());
        int resultnum;
        resultnum = num1-num2;
        Console.WriteLine("the subtraction of {0} - {1}  is  {2}",num1,num2,resultnum);
    }
}
