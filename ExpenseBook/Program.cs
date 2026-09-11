using ExpenseBook.Data;
using ExpenseBook.Logic;

IExpenseRepository repository = new ExpenseBookRepository();
var service = new ExpenseBookService(repository);
Console.WriteLine("Отобранные записи:");
foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Category} - {item.Amount}");
}
