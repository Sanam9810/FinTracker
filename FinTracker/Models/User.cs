namespace FinTracker.Models;

public class User
{
    public Guid UserId = Guid.NewGuid();
    public String Username { get; set; }
    public String Password { get; set; }
    public String CurrencyType { get; set; }
}