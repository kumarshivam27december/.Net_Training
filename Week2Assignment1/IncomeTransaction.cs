class IncomeTransaction : Transaction
{
    public string source { get; set; }
    public override string GetAllSummary()
    {
        return $"[Income]   {Date} | Rs {Amount} | Source {source}";
    }
}