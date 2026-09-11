using System.Net.Sockets;
using ExpenseBook.Logic;
namespace ExpenseBook.Data;
public class DemoExpenseRepository : IExpenseRepository
{
    public List<Expense> GetAll()
    {
        return new List<Expense>
        {
new Expense { Id = 100, Category = "Демонстрационная запись",
Amount = 1500}
};
    }

    public void Add(Expense item)
    {
        // Демонстрационное хранилище доступно только для чтения
    }

}