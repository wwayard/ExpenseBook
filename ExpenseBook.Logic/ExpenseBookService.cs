using System.Net.Sockets;
using ExpenseBook.Data;

namespace ExpenseBook.Logic;
public class ExpenseBookServise
{
    private readonly ExpenseBookRepository _repository = new();
    public List<Expense> GetImportant()
    {
        return _repository.GetAll()
        .Where(item => item.Amount  > 1000)
        .ToList();
    }
}
