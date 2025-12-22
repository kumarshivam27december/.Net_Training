class CaseBased1
{
    public static void Solve()
    {
        int n;

        System.Console.WriteLine("Enter year");
        n = Convert.ToInt32(System.Console.ReadLine());
        bool leap = true;

        if (n % 4 == 0)
        {
            if (n % 100 == 0)
            {
                if(n%400 != 0)
                {
                    leap = false;
                }
            }
        }
        else
        {
            leap = false;
        }

        if (leap == true)
        {
            System.Console.WriteLine("year is leap");
        }
        else
        {
            System.Console.WriteLine("year is not leap");
        }

    }
}