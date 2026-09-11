

using System.Net.Sockets;

namespace ExpenseBook.Logic;
public class ExpenseBookService
{
    private readonly IExpenseRepository _repository;

    public ExpenseBookService(IExpenseRepository repository)
    {       _repository = repository;
    }

    public List<Expense> GetImportant()
    {
        return _repository.GetAll()
        .Where(item => item.Amount  > 1000)
        .ToList();
    }

    public void AddExpense(string category, int amount)
    {
        if (string.IsNullOrWhiteSpace(category))
        {
            return;
        }
        int nextId = _repository.GetAll().Count + 1;
        _repository.Add(new Expense
        {
            Id = nextId,
            Category = category,
            Amount = amount
        });
    }

    public int GetTotalAmountByCategory(string category)
    {
        if (string.IsNullOrWhiteSpace(category))
        {
            return 0; 
        }

        return _repository.GetAll()
            .Where(item => item.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .Sum(item => item.Amount);
    }

}
