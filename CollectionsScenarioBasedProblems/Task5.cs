class Task5
{
    public static void Solve()
    {
        int noOfTransaction;
        noOfTransaction = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, double> transactions = new Dictionary<int, double>();

        int temp = noOfTransaction;
        while (temp-- > 0)
        {
            int transactionId = Convert.ToInt32(Console.ReadLine());
            double amount = Convert.ToDouble(Console.ReadLine());
            if (!transactions.ContainsKey(transactionId))
            {
                transactions.Add(transactionId, amount);
            }
        }

        SortedList<int,double> sortedList = new SortedList<int, double>();

        double averagePrice = 0.0d;
        foreach (KeyValuePair<int,double> keyValuePair in transactions)
        {
            averagePrice+=keyValuePair.Value;
        }

        int noOfUniqueTransaction = transactions.Count;
        averagePrice /= noOfUniqueTransaction;

        foreach(KeyValuePair<int,double> keyValuePair1 in transactions)
        {
            if(keyValuePair1.Value >= averagePrice)
            {
                sortedList.Add(keyValuePair1.Key,keyValuePair1.Value);
            }
        }

        Console.WriteLine("Sorted High value Transactions");

        foreach (KeyValuePair<int,double> keyValuePair2 in sortedList)
        {
            Console.WriteLine($"Transaction id is {keyValuePair2.Key} Amount is {keyValuePair2.Value}");
        }

    }
}