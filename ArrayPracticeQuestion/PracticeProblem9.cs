/*

9. Write a program in C# Sharp to find maximum and minimum element in an array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 45
element - 1 : 25
element - 2 : 21
Expected Output :
Maximum element is : 45
Minimum element is : 21
              


*/
using System;
class PracticeProblem9
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

        int max = arr[0];
        int min = arr[0];

        foreach (int item in arr)
        {
            if (item > max)
            {
                max = item;
            }
            if (item < min)
            {
                min = item;
            }
        }

        Console.WriteLine($"Maximum element is {max}");
        Console.WriteLine($"Minimum element is {min}");

    }
}