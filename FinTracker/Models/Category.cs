namespace FinTracker.Models;

public class Category
{
    public Guid CategoryId = Guid.NewGuid();
    public String Label { get; set; }
    public String Type { get; set; }
}