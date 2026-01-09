class Task3
{
    public static void Solve()
    {
        int noOfBranch;
        int noOfProduct;

        noOfBranch = Convert.ToInt32(Console.ReadLine());
        noOfProduct = Convert.ToInt32(Console.ReadLine());

        int[,] sales = new int[noOfBranch,noOfProduct];

        int productAverage  =  0;
        for(int i = 0; i < noOfBranch; i++)
        {
            for(int j = 0; j < noOfProduct; j++)
            {
                sales[i,j] = Convert.ToInt32(Console.ReadLine());
                productAverage += sales[i,j];
            }
        }

        productAverage /= (noOfBranch*noOfProduct); //calculating the final average price


        int[][] jaggedArray = new int[noOfBranch][];


        for(int i = 0; i < noOfBranch; i++)
        {
            int count = 0;
            for(int j = 0; j < noOfProduct; j++)
            {
                if(sales[i,j] >= productAverage)
                {
                    count++;
                }
            }

            jaggedArray[i] = new int[count];

            int index = 0;
            for(int j = 0; j < noOfProduct; j++)
            {
                if(sales[i,j]>= productAverage)
                {
                    jaggedArray[i][index] = sales[i, j];
                    index++;
                }
            }
        }


        Console.WriteLine("Jagged Array output is ");

        for (int i = 0; i < noOfBranch; i++)
        {
            Console.WriteLine($"Branch {i+1} is : ");
            for(int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j]);
            }
            Console.WriteLine();
        }

    }
}