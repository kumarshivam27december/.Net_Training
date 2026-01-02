/*

49)transpose of a matrix i.e swaping elements between row and column 


*/

class Problem7
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


        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {
                int temp = matrix1[i,j];
                matrix1[i,j] = matrix1[j,i];
                matrix1[j,i] = temp;
            }
        }

        for(int i = 0; i < row1; i++)
        {
            for(int j = 0; j < col1; j++)
            {
                Console.Write($" {matrix1[i,j]}");
            }
            Console.WriteLine();
        }
    }
}
