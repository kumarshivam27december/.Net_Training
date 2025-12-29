/*
12. Write a program in C# Sharp to sort elements of the array in descending order.               
Test Data :
Input the size of array : 3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 9
element - 2 : 1
Expected Output :
Elements of the array in sorted descending order:
9 5 1
              

*/

using System;
class PracticeProblem12
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

       
       for(int i = 0; i < arrLength; i++)
        {
            for(int j = i+1; j < arrLength; j++)
            {

                if (arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] =  temp;
                }
                
            }
        }

        Console.WriteLine("Elements of array in sorted ascending order : ");
        foreach (int item in arr)
        {
            Console.Write($" {item}");
        }
        
    }
}