/*
     *
    **
   ***
  ****
 *****

*/


class Problem27
{
    public static void Solve()
    {
        System.Console.WriteLine("Printing the pattern");
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());

        
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i + j >= n-1)
                {
                    System.Console.Write('*');
                }
                else
                {
                    System.Console.Write(' ');
                }
            }
            System.Console.WriteLine();
        }
    }
}