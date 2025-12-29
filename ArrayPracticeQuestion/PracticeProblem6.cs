/*
6. Write a program in C# Sharp to print all unique elements in an array.               
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5
              
*/


using System;
class PracticeProblem6
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



        Console.Write("The unique elements found in the array are :");
        for(int i = 0; i < arrLength; i++)
        {
            bool isUnique = true;
            for(int j = 0; j < arrLength; j++)
            {
                if (j != i)
                {
                    if(arr[j] == arr[i])
                    {
                        isUnique = false;
                    }

                }
            }

            if (isUnique)
            {
                Console.Write(arr[i]);
            }
        }
        
    }
}