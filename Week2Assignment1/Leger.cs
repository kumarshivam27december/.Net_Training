using System.Collections.Generic;
class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();
    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }
    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> outputResultArray =  new List<T>();
        foreach (T item in transactions)
        {
            if(item.Date.Date == date.Date)
            {
                outputResultArray.Add(item);
            }
        }

        return outputResultArray;
    }

    public float CalculateTotal()
    {
        float totalAmount = 0;
        foreach(T item in transactions)
        {
            totalAmount+= item.Amount;
        }
        return totalAmount;
    }
    public List<T> GetAllTransactions()
    {
        return transactions;
    }
}