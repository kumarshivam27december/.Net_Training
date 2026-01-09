using System.Collections;
class SortedListDemo
{
    public static void Demo()
    {
        SortedList list = new SortedList();
        list.Add(500,"rajesh");
        list.Add(200,"suresh");
        list.Add(300,"rakesh");
        list.Add(400,"john");
        list.Add(100,"david");

        ICollection keys = list.Keys;
        Console.WriteLine("All Keys are");
        foreach (var item in keys)
        {
            Console.WriteLine(item);
        }
        
        ICollection values = list.Values;
        Console.WriteLine("All values are");
        foreach (var item in values)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("All key values ");
        foreach(var item in keys)
        {
            Console.WriteLine($"key is {item} and value is {list[item]}");
        }

        Console.WriteLine($"Index 0 is having key {list.IndexOfKey(500)} and having value {list.IndexOfValue
        ("john")} ");


        list.Clear();
        Console.WriteLine("After clearing keys are ");
        foreach (var item in keys)
        {
            Console.WriteLine(item);
        }

        int count = list.Count;
        Console.WriteLine($"count is {count}");
    }
}