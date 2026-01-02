/*
48) matrix multiplication 2 by 2 
*/

class Problem6
{
    public static void Solve()
    {
        int row1,col1,row2,col2;
        Console.WriteLine("Enter row1 size ");
        row1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter col1 size");
        col1 = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[row1,col1];

        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {
                matrix1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        Console.WriteLine("Enter row2 size");
        row2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter col2 size");
        col2 = Convert.ToInt32(Console.ReadLine());
        int[,] matrix2 = new int[row2,col2];


        for(int i = 0; i < row2; i++)
        {
            for(int j = 0; j < col2; j++)
            {
                matrix2[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        int [,] result = new int[row1,col2];

        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {

                int temp = 0;
                for(int k = 0; k < col1; k++)
                {
                    temp += (matrix1[i,k]*matrix2[k,j]);
                }
                result[i,j] = temp;
            }
        }


        for (int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {
                Console.Write($" {result[i,j]}");
            }
            Console.WriteLine();
        }

    }
}