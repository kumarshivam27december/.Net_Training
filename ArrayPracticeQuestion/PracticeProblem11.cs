/*

11. Write a program in C# Sharp to sort elements of array in ascending order.               
Test Data :
Input the size of array : 5
Input 5 elements in the array :
element - 0 : 2
element - 1 : 7
element - 2 : 4
element - 3 : 5
element - 4 : 9
Expected Output :
Elements of array in sorted ascending order:
2 4 5 7 9
              

*/


using System;
class PracticeProblem11
{
    public static void Solve()
    {
        Console.WriteLine("Enter the length of array");
        int arrLength = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[arrLength];
        for(int i = 0; i < arrLength; i++)
        {
            Console.WriteLine($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

       
       for(int i = 0; i < arrLength; i++)
        {
            for(int j = i+1; j < arrLength; j++)
            {

                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] =  temp;
                }
                
            }
        }

        Console.WriteLine("Elements of array in sorted ascending order : ");
        foreach (int item in arr)
        {
            Console.Write($" {item}");
        }
        
    }
}