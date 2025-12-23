using System;
using System.Dynamic;
class PrimeNumber
{
    public static bool checkPrimeRootN(int num)
    {
        if (num < 2)
        {
            return false;
        }
        
        for(int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;   
    }
    public static void Solve()
    {
        int num;
        num = Convert.ToInt32(Console.ReadLine());


        for(int i = 1; i <= num; i++)
        {
            if (checkPrimeoptimized(i) == true)
            {
                System.Console.WriteLine(i);
            }
        }
    }


    public static bool checkPrimeoptimized(int num)
    {
        if (num < 2)
        {
            return false;
        }

        if (num < 4)
        {
            return true;
        }
        if (num%2==0 || num%3==0)
        {
            return false;
        }


        for(int i = 5; i * i <= num; i = i + 6)
        {
            if(num%i==0 || (num % (i + 2)) == 0)
            {
                return false;
            }
        }

        return true;
    }

}