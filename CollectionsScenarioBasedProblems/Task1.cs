class Task1
{
    public static void Solve()
    {
        Console.WriteLine("Enter the number of products");
        //asking user input to enter the no of products
        int arraySize = Convert.ToInt32(Console.ReadLine());

        //creating an integer array of that size
        int[] arr = new int[arraySize];
        for(int i = 0; i < arraySize; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            //accepting only positive prices for each product
            if (num < 0)
            {
                Console.WriteLine("Invalid Product ");
                Console.WriteLine("Exiting Program......");
                return ;
            }

            arr[i] = num;
        }

        //calculating average

        int averagePrice = 0;
        foreach (var item in arr)
        {
            averagePrice+=item;
        }
        averagePrice/=arraySize;

        //sorting the array

        Array.Sort(arr);

        //replace price below average with 0

        for(int i = 0; i < arraySize; i++)
        {
            if (arr[i] < averagePrice)
            {
                arr[i] = 0;
            }
        }

        //resize array by adding 5 new positions
        Console.WriteLine("Before resizing array size "+arraySize
        );
        Array.Resize(ref arr,arraySize+5);
        int newArraySize = arraySize+5;

        Console.WriteLine("After resizing array size "+arraySize
        );

        //fill the newly added position with average price

        for(int i = arraySize - 1; i < newArraySize; i++)
        {
            arr[i] = averagePrice;
        }

        //displaying the array with index position

        for (int i = 0; i < newArraySize; i++)
        {
            Console.WriteLine($"Index is {i} value is {arr[i]}");
        }

    }
}