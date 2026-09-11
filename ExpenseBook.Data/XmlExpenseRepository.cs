using System.Net.Sockets;
using System.Xml.Serialization;
using ExpenseBook.Logic;
namespace ExpenseBook.Data;
public class XmlExpenseRepository : IExpenseRepository
{
    private readonly string _path;
    private readonly XmlSerializer _serializer =
    new(typeof(List<Expense>));
    public XmlExpenseRepository(string path)
    {
        _path = path;
    }
    public List<Expense> GetAll()
    {
        if (!File.Exists(_path))
        {
            return new List<Expense>();
        }
        using var reader = new StreamReader(_path);
        return _serializer.Deserialize(reader) as List<Expense> ?? new
        List<Expense>();
    }
    public void Add(Expense item)
    {
        List<Expense> items = GetAll();
        items.Add(item);
        using var writer = new StreamWriter(_path);
        _serializer.Serialize(writer, items);
    }
}
