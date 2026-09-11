
using System.Net.Sockets;

namespace ExpenseBook.Logic;
public interface IExpenseRepository
{
    List<Expense> GetAll();
    void Add(Expense item);

}
