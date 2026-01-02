/*


47)program to find the largest and smallest element in the 
array    


*/

class Problem5
{
    public static void Solve()
    {
        int[] arr = {10,3,5,61,8,1};
        int largest = arr[0];
        int smallest = arr[0];

        foreach (int item in arr)
        {
            if (item > largest)
            {
                largest = item;
            }
            if (item < smallest)
            {
                smallest = item;
            }
            
        }

        Console.WriteLine("Largest is {0}",largest);
        Console.WriteLine("Smallest is {0}",smallest);
    }
}