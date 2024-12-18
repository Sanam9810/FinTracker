namespace FinTracker.Models;

public class Debt
{
    public Guid DebtId = Guid.NewGuid();
    public String DueDate { get; set; }
    public String Status { get; set; }
    public String SourceOfDebt { get; set; }
    public float TotalAmount { get; set; }
    public float RemainingAmount { get; set; }
}