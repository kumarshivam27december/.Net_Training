class Task4
{
    public static void Solve()
    {
        Console.WriteLine("Enter the no of customer transaction");
        int noOfTransaction = Convert.ToInt32(Console.ReadLine());

        int temp = noOfTransaction;
        List<int> list = new List<int>();
        while(temp-- > 0)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            list.Add(num);
        }

        HashSet<int> hashSet = new HashSet<int>(list);


        List<int> newList = new List<int>(hashSet);
        Console.WriteLine("Cleaned customer list");

        HashSet<int> seen = new HashSet<int>();

        foreach(int item in list)
        {
            if (!seen.Contains(item))
            {
                Console.WriteLine($"{item}");
            }
            seen.Add(item);
        }
        Console.WriteLine($"No of customer removed is {list.Count - newList.Count}");
    }
}