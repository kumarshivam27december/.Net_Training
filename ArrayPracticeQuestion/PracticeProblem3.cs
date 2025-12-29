/*
3. Write a program in C# Sharp to find the sum of all elements of the array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15

*/

using System;
class PracticeProblem3
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

        int sum = 0;

        foreach (int item in arr)
        {
            sum+=item;
        }

        Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
        
    }
}