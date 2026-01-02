/*

46b)program to add 2 matrices    


*/

class Problem4
{
    public static void Solve()
    {
        int[,] arr = new int[,] {{1,2,3,4},{5,6,7,8}};
        int[,] arr1 = new int[,] {{10,20,30,40},{50,60,70,80}};

        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);


        int [,] newarr = new int[rows,cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                newarr[i,j] = arr[i,j] + arr1[i,j];
            }
        }


        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($" {newarr[i,j]}");
            }
            Console.WriteLine();
        }
    }
}