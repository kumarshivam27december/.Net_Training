/*2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order.               
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2*/


using System;
class PracticeProblem2
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
        for(int i = arrLength-1;i>=0;i--)
        {
            Console.Write($" {arr[i]}");
        }

    
        
    }
}