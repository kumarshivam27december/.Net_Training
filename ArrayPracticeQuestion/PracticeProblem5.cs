/*

5. Write a program in C# Sharp to count a total number of duplicate elements in an array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 1
element - 2 : 1
Expected Output :
Total number of duplicate elements found in the array is : 1

*/

using System;
class PracticeProblem5
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

        int totalDublicate = 0;
        for(int i = 0; i < arrLength; i++)
        {
            for(int j = i + 1; j < arrLength; j++)
            {
                if(arr[i] == arr[j])
                {
                    totalDublicate++;
                }
            }
        }

        Console.WriteLine($"Total number of dublicate element are : {totalDublicate}");
        
    }
}
