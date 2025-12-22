/*


     1
    12
   123
  1234
 12345


*/



class Problem26
{
    public static void Solve()
    {
        System.Console.WriteLine("Printing the pattern");
        int n;
        System.Console.WriteLine("enter a number");
        n = Convert.ToInt32(System.Console.ReadLine());

        int helper = n-1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i+j<helper)
                {
                    System.Console.Write(' ');
                }else if (i + j == helper)
                {
                    System.Console.Write(1);
                }
                else
                {
                    System.Console.Write((i+j-helper+1));
                }
            }
            System.Console.WriteLine();
        }
    }
}