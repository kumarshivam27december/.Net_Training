using System;
class Calculator
{
    public int Add() //method with no parameter 
    {
        int num1 = 59;
        int num2 = 10;
        return num1+num2;
    }


    // public string Add()
    // {
    //      int num1 = 59;
    //      int num2 = 10;
    //     return ToString(num1+num2);
    // }   //Error not implementing polymorphism

    public int Add(int n) //method with single parameter
    {
        int num1 = 59;
        int num2 = n;
        return num1+num2;
    }


    public int Add(int number1,int number2) //method with double parameter
    {
        return number1+number2;
    }


    public int Add(string number1,string number2)
    {
        string str = number1+number2;
        Console.WriteLine($"concatenated string is{str}");
        return 0;
    }

    public int Add(string str1,float num1,int num2)
    {
        Console.WriteLine($"String is {str1} \n float is {num1} \n num is {num2}");
        return 0;
    }




}