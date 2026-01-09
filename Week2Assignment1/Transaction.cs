using System;
abstract class Transaction : IReport
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public float Amount { get; set; }
    public string Description { get; set; }

    public abstract string GetAllSummary();
}
