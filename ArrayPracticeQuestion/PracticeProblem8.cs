/*

8. Write a program in C# Sharp to count the frequency of each element of an array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 25
element - 1 : 12
element - 2 : 43
Expected Output :
Frequency of all elements of array :
25 occurs 1 times
12 occurs 1 times
43 occurs 1 times

*/

using System;
class PracticeProblem8
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

        int[] newarr = new int[arrLength];
        for(int i = 0; i < arrLength; i++)
        {
            int cnt = 1;
            for(int j = 0; j < arrLength; j++)
            {
                if (i != j)
                {
                    if(arr[i] == arr[j])
                    {
                        cnt++;
                    }
                }
            }

            newarr[i] = cnt;

        }

        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine($"{arr[i]}  occured {newarr[i]} times");
        }
        
    }
}