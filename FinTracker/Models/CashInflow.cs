namespace FinTracker.Models;

public class CashInflow
{
    public Guid Id = Guid.NewGuid();
    public float Amount { get; set; }
    public String Date { get; set; }
}