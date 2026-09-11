using System.Text.Json;
using System.Text.Encodings.Web;
using ExpenseBook.Logic;
using System.Net.Sockets;

namespace ExpenseBook.Data;

public class JsonExpenseRepository : IExpenseRepository
{
    private readonly string _path;
    private readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };



    public JsonExpenseRepository(string path)
    {
        _path = path;

    }

    public List<Expense> GetAll()
    {

        if (!File.Exists(_path))
        {
            return new List<Expense>();
        }
        string text = File.ReadAllText(_path);
        try
        {
            return JsonSerializer.Deserialize<List<Expense>>(text) ?? new
            List<Expense>();
        }
        catch (JsonException)
        {
            return new List<Expense>();
        }
    }

   
    public void Add(Expense item)
    {
        List<Expense> items = GetAll();
        items.Add(item);
        string text = JsonSerializer.Serialize(items, _options);
        File.WriteAllText(_path, text);
    }
}