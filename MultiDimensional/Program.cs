using System;
class Program
{
    public static void Main(string[] args)
    {
        int[][] jaggedArr = new int[4][];

        jaggedArr[0] = new int[] {1,2,3,4};
        jaggedArr[1] = new int[] {11,34,67};
        jaggedArr[2] = new int[] {89,23};
        jaggedArr[3] = new int[] {69,96,84};

        //display the array elements:
        for(int n = 0; n < jaggedArr.Length; n++)
        {
            //print the row number
            // Console.WriteLine("Row({0})",n);
            for(int k = 0; k < jaggedArr[n].Length; k++)
            {
                Console.Write($" {jaggedArr[n][k]}");
            }
            Console.WriteLine();
        }
    }
}