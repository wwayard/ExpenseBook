
using ExpenseBook.Logic;
using ExpenseBook.Data;


string jsonPath = Path.Combine(AppContext.BaseDirectory,
"expenses.json");
string xmlPath = Path.Combine(AppContext.BaseDirectory,
"expenses.xml");

string kind = args.Length > 0 ? args[0] : "json";

IExpenseRepository repository = kind switch
{
    "xml" => new XmlExpenseRepository(xmlPath),
    "memory" => new ExpenseBookRepository(),
    _ => new JsonExpenseRepository(jsonPath)
};
Console.WriteLine($"Хранилище: {kind}");
var service = new ExpenseBookService(repository);


Console.Write("Тема новой категории: ");
string category = Console.ReadLine() ?? "";

service.AddExpense(category, 3200);
Console.WriteLine("Отобранные записи:");

foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.Category} - {item.Amount}");
}

Console.WriteLine($"Сумма расходов по заданной категории: {service.GetTotalAmountByCategory("прооооо")}");
