using System.Collections;
class HashTableDemo
{
    public static void Demo()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(100,"Rajesh");
        hashtable.Add(200,"Suresh");
        hashtable.Add(300,"Rakesh");
        hashtable.Add(400,"John");
        hashtable.Add(500,"David");
        ICollection key = hashtable.Keys;
        Console.WriteLine("All keys are ");
        foreach (var item in key)
        {
            Console.WriteLine(item);
        }
        ICollection value = hashtable.Values;
        Console.WriteLine("All values are");
        foreach (var item in value)
        {
            Console.WriteLine(item);
        }

        foreach(var k in key)
        {
            Console.WriteLine($"key is {k} and value is {hashtable[k]}");
        }


        Console.WriteLine("Enter the key to search");
        int userInputKey = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value to search");
        int userInputValue = Convert.ToInt32(Console.ReadLine());

        if (hashtable.ContainsKey(userInputKey))
        {
            Console.WriteLine($"{userInputKey} is found and the value is {hashtable[userInputKey]}");
        }
        else
        {
            Console.WriteLine("Key not found");
        }
    }
}