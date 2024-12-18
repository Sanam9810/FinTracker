namespace FinTracker.Models;

public class Transaction
{
    public Guid TransactionId = Guid.NewGuid();
    public float Amount { get; set; }
    public String Title { get; set; }
    public String Type { get; set; }
    public String DateOfTransaction { get; set; }
    public String Notes { get; set; }
}