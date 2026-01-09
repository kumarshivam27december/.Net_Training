using System.Collections;

class Task7
{
    public static void Solve()
    {

        Hashtable hashtable = new Hashtable();
        ArrayList arrayList = new ArrayList();
        Console.WriteLine("Enter no of user");
        int noofUsers = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name along with role");
        int temp = noofUsers;
        while(temp-- > 0)
        {
            string userName = Console.ReadLine() ?? "";
            string userRole = Console.ReadLine() ?? "";
            
            hashtable.Add(userName,userRole);
            arrayList.Add(userName);
            arrayList.Add(userRole);
        }


        Console.WriteLine("Intentionally adding wrong different datatypes");
        arrayList.Add(100);
        arrayList.Add(true);

        Console.WriteLine("\n hashtable data -> safe  structure \n");

        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"key is {entry.Key} value is {entry.Value}");
        }

        Console.WriteLine();

        Console.WriteLine("\n array list (mixed and risky)");

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("arraylist allow mixed data types");
        Console.WriteLine("this cause runtime confusion and error");
        Console.WriteLine("hashtable provide better structure but no type safety");

    }
}