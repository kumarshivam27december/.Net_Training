/*

4. Write a program in C# Sharp to copy the elements one array into another array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 15
element - 1 : 10
element - 2 : 12
Expected Output:
The elements stored in the first array are :
15 10 12
The elements copied into the second array are :
15 10 12
              
*/

using System;
class PracticeProblem4
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

        int[] arr2 = arr;

        Console.Write("Elements in Array are:");
        foreach (int  item in arr2)
        {
            Console.Write($" {item}");
        }

    }
}