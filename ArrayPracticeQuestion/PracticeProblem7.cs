/*


7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.               
Test Data :
Input the number of elements to be stored in the first array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 2
element - 2 : 3
Input the number of elements to be stored in the second array :3
Input 3 elements in the array:
element - 0 : 1
element - 1 : 2
element - 2 : 3
Expected Output:
The merged array in ascending order is :
1 1 2 2 3 3


*/

using System;
using System.Runtime.CompilerServices;
class PracticeProblem7
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

       
        int arr2Length = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[arr2Length];


        for(int i = 0; i < arr2Length; i++)
        {
            Console.WriteLine($"element - {i} : ");
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }
        

        int[] arr3 = new int[arrLength+arr2Length];

        for(int i = 0; i < arrLength; i++)
        {
            arr3[i] = arr[i];
        }

        for(int j = 0; j < arr2Length; j++)
        {
            arr3[arrLength+j] = arr2[j];
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

        foreach (int item in arr3)
        {
            Console.WriteLine($"{ item}");
        }

    }
}