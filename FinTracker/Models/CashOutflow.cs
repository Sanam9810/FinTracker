namespace FinTracker.Models;

public class CashOutflow
{
    public Guid Id = Guid.NewGuid();
    public float Amount { get; set; }
    public String Date { get; set; }
}