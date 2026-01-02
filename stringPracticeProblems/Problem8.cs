/*


50) program to find whether the given matrix is diagonal 
matrix or not  


*/
class Problem8
{
    public static void Solve()
    {
        int row1,col1;
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


        bool isDiagonal = true;
        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {
                if (i != j)
                {
                    if (matrix1[i, j] != 0)
                    {
                        isDiagonal = false;  
                        break; 
                    }
                }
            }
        }

        if (isDiagonal)
        {
            Console.WriteLine("it is a diagonal matrix");
        }
        else
        {
            Console.WriteLine("It is not a diagonal matrix");
        }


        
    }
}