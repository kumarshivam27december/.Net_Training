/*
1. Write a program in C# Sharp to store elements in an array and print it.               
Test Data:
Input 10 elements in the array:
element - 0 : 1
element - 1 : 1
element - 2 : 2
.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 9
*/
using System;
class PracticeProblem1
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

        Console.Write("Elements in Array are:");
        foreach (int  item in arr)
        {
            Console.Write($" {item}");
        }

        
    }
}