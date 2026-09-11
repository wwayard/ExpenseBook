// See https://aka.ms/new-console-template for more information
using ExpenseBook.Logic;
var service = new ExpenseBookServise();
Console.WriteLine("Отобранные записи:");
foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Category} - {item.Amount}");
}
