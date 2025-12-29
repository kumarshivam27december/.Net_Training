/*

14. Write a program in C# Sharp to insert New value in the array (unsorted list ).               
Test Data :
Input the size of array : 4
Input 4 elements in the array in ascending order:
element - 0 : 1
element - 1 : 8
element - 2 : 7
element - 3 : 10
Input the value to be inserted : 5
Input the Position, where the value to be inserted :2
Expected Output :
The current list of the array :
1 8 7 10
After Insert the element the new list is :
1 5 8 7 10
              

*/


using System;
class PracticeProblem14
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

        Console.WriteLine("Enter the value to be inserted");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the position to be inserted");
        int position = Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref arr,arrLength+1);
        arrLength+=1;

        for(int i = arrLength-1; i >=0; i--)
        {
            if (i == position)
            {
                break;
            }
            else
            {
                
             arr[i] = arr[i-1];
            }
        }

        arr[position] = arr[position-1];
        arr[position-1] = value;

        foreach (int item in arr)
        {
            Console.Write($" {item}");
        }


        
    }
}