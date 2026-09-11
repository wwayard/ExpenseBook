namespace ExpenseBook.Data;
public class Expense
{
    public int Id { get; set; }
    public string Category { get; set; } = "";
    public int Amount { get; set; }
}