/*
13. Write a program in C# Sharp to insert New value in the array (sorted list ).               
Test Data :
Input the size of array : 3
Input 3 elements in the array in ascending order:
element - 0 : 5
element - 1 : 7
element - 2 : 9
Input the value to be inserted : 8
Expected Output :
The exist array list is :
5 7 9
After Insert the list is :
5 7 8 9

*/

using System;
class PracticeProblem13
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

        Array.Resize(ref arr,arrLength+1);
        Console.WriteLine("Enter the number to insert :");
        int input = Convert.ToInt32(Console.ReadLine());

        arrLength += 1;
        arr[arrLength-1] = input;

         
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

        foreach (int item in arr)
        {
            Console.WriteLine($" {item}");
        }
        
    }
}