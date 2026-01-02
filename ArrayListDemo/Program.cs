using System.Buffers;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        Console.WriteLine($"Count of array list is {list.Count}");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Add(69.69f);
        list.Add(false);


        Console.WriteLine($"Count of array list is {list.Count}");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }


        Employee employee1 = new Employee() { Id = 10, Name = "shivam0" };
        Employee employee2 = new Employee() { Id = 11, Name = "shivam1" };
        Employee employee3 = new Employee() { Id = 12, Name = "shivam2" };

        list.Add(employee1);
        list.Add(employee2);
        list.Add(employee3);

        Console.WriteLine($"Count of array list is {list.Count}");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }


        ArrayList list1 = new ArrayList();
        list1.Add(67);
        list1.Add(68);
        list1.Add(69);

        list.AddRange(list1);

        Console.WriteLine("\n\n\n After adding add range");
        Console.WriteLine($"Count of array list is {list.Count}");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Count of array list before clearing is {list.Count}");


        list.Clear();
        Console.WriteLine($"Count of array list After clearing is {list.Count}");


        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        if (list.Contains(50))
        {
            Console.WriteLine($"Element 50 found at index {list.IndexOf(50)}");
        }
        else
        {
            Console.WriteLine("Element not found");
        }

        list.Remove(40);
        Console.WriteLine("After using remove ");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveAt(2);
        Console.WriteLine("After using remove at ");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        ArrayList list2 = new ArrayList();
        list2.Add(67);
        list2.Add(68);
        list2.Add(69);

        list.AddRange(list2);


        Console.WriteLine("Before remove range");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.RemoveRange(2, 3);

        Console.WriteLine("after removing from 2 index count of 3");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("List before sorting");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Sort();
        Console.WriteLine("List after sorting");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Before reversing");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        list.Reverse();

        Console.WriteLine("After reversing");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Before Inserting ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("After Inserting");
        list.Insert(0, 69);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        ArrayList list3 = new ArrayList();
        list3.Add(99);
        list3.Add(999);
        list3.Add(9999);

        list.InsertRange(1, list3);

        Console.WriteLine("after insert range operation ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}