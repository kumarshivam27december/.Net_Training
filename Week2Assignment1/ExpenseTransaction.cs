
class ExpenseTransaction : Transaction
{
    public string category { get; set; }

    public override string GetAllSummary()
    {
        return $"[Expense]  {Date} | Rs {Amount} | Source {category}";
    }
}