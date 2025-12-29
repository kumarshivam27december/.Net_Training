/*

10. Write a program in C# Sharp to separate odd and even integers in separate arrays.               
Test Data :
Input the number of elements to be stored in the array :5
Input 5 elements in the array :
element - 0 : 25
element - 1 : 47
element - 2 : 42
element - 3 : 56
element - 4 : 32
Expected Output:
The Even elements are:
42 56 32
The Odd elements are :
25 47

*/
using System;
class PracticeProblem10
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

        Console.Write("The even Elements are : ");
        foreach (int item in arr)
        {
            if (item % 2 == 0)
            {
                Console.Write($" {item}");
            }
        }

        Console.Write("The Odd Elements are : ");
        foreach (int item in arr)
        {
            if (item % 2 != 0)
            {
                Console.Write($" {item}");
            }
        }
    }
}