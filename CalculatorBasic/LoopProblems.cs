using System;
class LoopLearning
{
    public static void Loops()
    {

        System.Console.WriteLine("while loop ");
        int i;
        i = 0;
        while (i <= 10)
        {
            Console.WriteLine($"number is {i}");
            i++;
        }


        System.Console.WriteLine("reverse using while loop");
        int k =10;
        while (k >= 0)
        {
            Console.WriteLine($"number is {k}");
            k--;
        }

        System.Console.WriteLine("do while loop");
        int temp = 0;
        do
        {
            Console.WriteLine($"the number is {temp}");
            temp++;
        }while(temp<=10);


        System.Console.WriteLine("reverse using do while loop");
        int temp1 = 10;
        do
        {
            temp1--;
            System.Console.WriteLine($"reverse order is {temp1}");
        }while(temp1>0);


        System.Console.WriteLine("for loop");
        for(int j = 0; j < 10; j++)
        {
            System.Console.WriteLine($"the numbers are {j}");
        }

        System.Console.WriteLine("reverse using for loop");
        for(int j = 10; j > 0; j--)
        {
            System.Console.WriteLine($"the reverse order number are {j}");
        }



        System.Console.WriteLine("Array traversal using for each loop");
        int[] arr = {1,2,3,4,5};
        foreach(int itr in arr){
                Console.Write($"{itr} ");
        }


        System.Console.WriteLine("Array traversal using for loop");
        for(int itr = 0; itr < arr.Length-1; itr++)
        {
            Console.WriteLine($"the element at index {itr} is {arr[itr]}");
        }


        System.Console.WriteLine("Array traversal using while loop");
        int itrs = 0;
        while (itrs < arr.Length)
        {
            Console.Write($"Element at index {itrs} is {arr[itrs]}");
            itrs++;
            Console.WriteLine();
        }


    }
}