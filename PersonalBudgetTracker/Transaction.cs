namespace PersonalBudgetTracker
{
    public class Transaction
    {
        public string Description { get; set; } = "";
        public decimal Amount { get; set; }
        public string Type { get; set; } = "";
    }
}