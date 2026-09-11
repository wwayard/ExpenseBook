

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
}
