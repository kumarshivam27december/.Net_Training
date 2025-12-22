class CaseBased4
{
    public static void Solve()
    {
        string inputchar;
        
        while (true)
        {
            inputchar = System.Console.ReadLine() ?? "";
            if(inputchar=="Q" || inputchar == "q")
            {
                break;
            }
            
            int num = Convert.ToInt32(inputchar);
            if (num < 0)
            {
                System.Console.WriteLine("Invalid negative number");
            }

            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact*=i;
            }
            System.Console.WriteLine(fact);

        }

    }
}