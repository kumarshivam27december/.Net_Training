/*


15. Write a program in C# Sharp to delete an element at desired position from an array.               
Test Data :
Input the size of array : 5
Input 5 elements in the array in ascending order:
element - 0 : 1
element - 1 : 2
element - 2 : 3
element - 3 : 4
element - 4 : 5
Input the position where to delete: 3
Expected Output :
The new list is : 1 2 4 5


*/

using System;
class PracticeProblem15
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

        Console.WriteLine("Enter the position to delete");
        int deleteInput = Convert.ToInt32(Console.ReadLine());


        for(int i = deleteInput-1; i < arrLength-1; i++)
        {
            arr[i] = arr[i+1];
        }

        Array.Resize(ref arr,arrLength-1);


        foreach (int item in arr)
        {
            Console.Write($" {item}");
        }


        
    }
}
