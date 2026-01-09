using System.Collections.Generic;
class GenericDictionaryDemo
{
    public static void Demo()
    {
        Dictionary<int,string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1,"Shivam");
        dictionary.Add(2,"Rahul");
        dictionary.Add(3,"Sourav");

        foreach (KeyValuePair<int,string> keyValuePair in dictionary)
        {
            Console.WriteLine($"key is {keyValuePair.Key} value is {keyValuePair.Value}");
        }
    }
}