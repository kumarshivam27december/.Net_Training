class Task2
{
    public static void Solve()
    {
        int noOfBranches;
        int noOfMonths;
        Console.WriteLine("Enter the no of branches");
        noOfBranches = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the no of months");
        noOfMonths =  Convert.ToInt32(Console.ReadLine());

        int[,] MultiDimentionalArray = new int[noOfBranches,noOfMonths];

        for (int i = 0; i < noOfBranches; i++)
        {
            for (int j = 0; j < noOfMonths; j++)
            {
                MultiDimentionalArray[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        for(int i = 0; i < noOfBranches; i++)
        {
            int totalSale = 0;
            for(int j = 0; j < noOfMonths; j++)
            {
                totalSale += MultiDimentionalArray[i,j];
            }

            Console.WriteLine($"total sale for branch {i}  is {totalSale}");
        }



        for(int i = 0; i < noOfBranches; i++)
        {
            int highestMonthlySale = MultiDimentionalArray[0,0];
            for(int j = 0; j < noOfMonths; j++)
            {
                if(MultiDimentionalArray[i,j] > highestMonthlySale)
                {
                    highestMonthlySale = MultiDimentionalArray[i,j];
                }
            }
            Console.WriteLine($"highest monthly sale for {i} branch is {highestMonthlySale}");
        }
    }
}