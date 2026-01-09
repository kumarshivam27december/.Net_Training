using System.Collections.Generic;
class GenericSortedListDemo
{
    public static void Demo()
    {
        SortedList<string,string> pairs = new SortedList<string, string>();
        pairs.Add("100","Rajesh");
        pairs.Add("200","Ramesh");
        pairs.Add("300","Rakesh");

        Console.WriteLine("\n\n\n Generic Sorted List");
        foreach (KeyValuePair<string,string> keyValuePair in pairs)
        {
            Console.WriteLine($"Key is {keyValuePair.Key} , value is {keyValuePair.Value}");
        }

    }
}