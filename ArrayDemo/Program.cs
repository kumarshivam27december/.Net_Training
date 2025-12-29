using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    public static void Main(string[] args)
    {
        /*
        int[] arr;//array declaration
        arr = new int[6]; //array initilaztion
        //assigning values to it
        arr[0] = 10; //arr[0] index number start with zero
        arr[1] = 20;
        arr[2] = 30;
        arr[3] = 40;
        arr[4] = 50;
        arr[5] = 60;
        int length = arr.Length;
        Console.WriteLine("Length of the array is "+length);        
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Element at index {i} is {arr[i]}");
        }
        foreach(int itr in arr){
            Console.WriteLine($"Element is {itr}");
        }

        */


        /*

        int[] arr;
        Console.WriteLine("Enter the length of the array: ");

        int length = Convert.ToInt32(Console.ReadLine());

        arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Enter the element at index {i} ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine($"length of the array is {length}");


        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Element at index {i} is {arr[i]}");
        }

        foreach (int itr in arr)
        {
            Console.WriteLine($"Elements are {itr}");
        }


        */


        /*
        char[] ch = new char[10] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'I', 'J', 'K' };

        foreach (char item in ch)
        {
            Console.WriteLine($"element is  {item}");
        }

        for (int i = 0; i < ch.Length; i++)
        {
            Console.WriteLine($"Element at index {i} is {arr[i]}");
        }

        Console.WriteLine("Enter the length of char array");
        int length2 = Convert.ToInt32(Console.ReadLine());

        char[] ch1 = new char[length2];

        Console.WriteLine("Enter characters");
        for (int i = 0; i < length2; i++)
        {
            ch[i] = Convert.ToChar(Console.ReadLine() ?? "");
        }

        for (int i = 0; i < length2; i++)
        {
            Console.WriteLine($"Elements at index {i} is {ch1[i]}");
        }


        */


        /*
        string[] employeeNames;

        Console.WriteLine("Enter the length of string");
        int length3 = Convert.ToInt32(Console.ReadLine());
        employeeNames = new string[length3];


        for (int i = 0; i < length3; i++)
        {
            employeeNames[i] = Console.ReadLine() ?? "";
        }

        for (int i = 0; i < length3; i++)
        {
            Console.WriteLine($"element of string array is {employeeNames[i]}");
        }

        foreach (string item in employeeNames)
        {
            Console.WriteLine($"{item}");
        }

        */


        /*
        Program program = new Program();
        int[] arr2 = {10,20,30,40};
        program.PassArrayDemo(arr2);


        int[] arr1 = program.ReturnArrayDemo(6);
        Console.WriteLine("Elements from return array are :");
        for(int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine($"Element at index {i} is {arr1[i]}");
        }
        */



        /*

        int [,] arr= new int[3,3];
        arr[0,0] = 10;
        arr[0,1] = 20;
        arr[0,2] = 30;

        arr[1,0] = 40;
        arr[1,1] = 50;
        arr[1,2] = 60;

        arr[2,0] = 70;
        arr[2,1] = 80;
        arr[2,2] = 90;


        Console.WriteLine("Element in 3 X 3 matrix are ");


        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write($"  {arr[i,j]}");
                
            }
            Console.WriteLine();
        }


        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"  {arr[i,j]}");
                
            }
            Console.WriteLine();
        }

        */

        //accepting user input for 3 X 3 matrix

        int k = 0;
        int l = 0;

        Console.WriteLine("Enter no of rows: ");
        k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter no of cols");
        l = Convert.ToInt32(Console.ReadLine());

        int [,] arr = new int[k,l];

        Console.WriteLine($"Enter element in {k} X {l} matrix is : ");

        for(int i= 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(0); j++)
            {
                Console.WriteLine($"Enter element at {i} of {j} is : ");
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(0); j++)
            {
                Console.Write($"  {arr[i,j]}");
                
            }
            Console.WriteLine();
        }

    }
    public void PassArrayDemo(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"sum of all array is {sum}");
    }

    public int[] ReturnArrayDemo(int length)
    {
        int[] arr = new int[length];
        Console.WriteLine($"Enter {length} no of elements");

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"Enter element at index {i} ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        return arr;
    }


}