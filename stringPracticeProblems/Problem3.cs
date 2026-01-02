/*

46a)program to accept 2x2 matrices and display in matrix    


*/


class Problem3
{
    public static void Solve()
    {
        int rows;
        int cols;
        rows  = Convert.ToInt32(Console.ReadLine());
        cols  = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[rows,cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("display");
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"  {arr[i,j]}");
            }
            Console.WriteLine();
        }

        
    }
}