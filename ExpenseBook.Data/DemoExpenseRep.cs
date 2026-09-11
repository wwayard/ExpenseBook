using System.Net.Sockets;
using ExpenseBook.Logic;
namespace SupportDesk.Data;
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
}