using System.Data.Common;

class Program
{
    public static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeLeger = new Ledger<IncomeTransaction>();

        Console.WriteLine("Enter no of income transaction");
        int noOfUserTransaction = Convert.ToInt32(Console.ReadLine());
        while (noOfUserTransaction-- > 0)
        {
            Console.WriteLine("Enter income transaction id ");
            int id = Convert.ToInt32(Console.ReadLine());
            DateTime d1 = DateTime.Today;
            Console.WriteLine("Enter amount in float");
            float amount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter source in string");
            string source1 = Console.ReadLine() ?? "";
            Console.WriteLine("Enter description in string");
            string Description1 = Console.ReadLine() ?? "";

            incomeLeger.AddEntry(new IncomeTransaction { Id = id, Date = d1, Amount = amount, source = source1, Description = Description1 });
        }

        Ledger<ExpenseTransaction> expenseLeger = new Ledger<ExpenseTransaction>();
        Console.WriteLine("Enter the no of expense transaction");
        int noOfUserExpenseTransaction = Convert.ToInt32(Console.ReadLine());
        while(noOfUserExpenseTransaction-- > 0)
        {
            Console.WriteLine("Enter income transaction id ");
            int id = Convert.ToInt32(Console.ReadLine());
            DateTime d1 = DateTime.Today;
            Console.WriteLine("Enter amount in float");
            float amount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter category in string");
            string category1 = Console.ReadLine() ?? "";
            Console.WriteLine("Enter description in string");
            string Description1 = Console.ReadLine() ?? "";
            expenseLeger.AddEntry(new ExpenseTransaction{Id = id,Date = d1,Amount = amount,category = category1 ,Description = Description1});
        }

        
        float totalincome = incomeLeger.CalculateTotal();
        float totalexpense = expenseLeger.CalculateTotal();
        float totalnetBalance = totalincome - totalexpense;


        Console.WriteLine("All cash summary"); 


        Console.WriteLine($"total income is {totalincome}");
        Console.WriteLine($"total expense is {totalexpense}");
        Console.WriteLine($"net balance is {totalnetBalance}");




        Console.WriteLine("transaction details");

        List<Transaction> alltransactions = new List<Transaction>();

        foreach (IncomeTransaction item in incomeLeger.GetAllTransactions())
        {
            alltransactions.Add(item);
        }

        foreach (ExpenseTransaction item in expenseLeger.GetAllTransactions())
        {
            alltransactions.Add(item);            
        }


        foreach(Transaction item in alltransactions)
        {
            Console.WriteLine(item.GetAllSummary());
        }
    }
}














