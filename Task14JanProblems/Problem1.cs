class Problem1
{
    public static SortedDictionary<string, long> itemDetails =
        new SortedDictionary<string, long>()
        {
            { "Pen", 120 },
            { "Pencil", 80 },
            { "Notebook", 200 },
            { "Eraser", 50 },
            { "Marker", 150 }
        };

    public static SortedDictionary<string, long> FindItemDetails(long soldCount)
    {
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        foreach (var item in itemDetails)
        {
            if (item.Value == soldCount)
            {
                result.Add(item.Key, item.Value);
            }
        }

        return result;
    }

    public static List<string> FindMinandMaxSoldItems()
    {
        List<string> result = new List<string>();

        long minSold = itemDetails.Values.Min();
        long maxSold = itemDetails.Values.Max();

        string minItem = itemDetails.First(i => i.Value == minSold).Key;
        string maxItem = itemDetails.First(i => i.Value == maxSold).Key;

        result.Add(minItem); 
        result.Add(maxItem);

        return result;
    }

    public static Dictionary<string, long> SortByCount()
    {
        return itemDetails
            .OrderBy(i => i.Value)
            .ToDictionary(i => i.Key, i => i.Value);
    }

    public static void Demo(string[] args)
    {
        long soldCount = Convert.ToInt64(Console.ReadLine());

        var foundItems = FindItemDetails(soldCount);

        if (foundItems.Count == 0)
        {
            Console.WriteLine("Invalid sold count");
        }
        else
        {
            foreach (var item in foundItems)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        List<string> minMaxItems = FindMinandMaxSoldItems();
        Console.WriteLine("Minimum Sold Item: " + minMaxItems[0]);
        Console.WriteLine("Maximum Sold Item: " + minMaxItems[1]);

        Dictionary<string, long> sortedItems = SortByCount();
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}