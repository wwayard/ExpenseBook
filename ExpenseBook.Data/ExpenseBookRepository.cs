
using ExpenseBook.Logic;

namespace ExpenseBook.Data;
public class ExpenseBookRepository : IExpenseRepository
{
    private readonly List<Expense> _items = new()
    {
new Expense { Id = 1, Category = "Проезд",
    Amount = 1200 },
new Expense { Id = 2, Category = "Коммуналка",
    Amount = 3500 },
new Expense { Id = 1, Category = "Кофе",
    Amount = 200 },
};
    public List<Expense> GetAll()
    {
        return _items;
    }
}