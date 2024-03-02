namespace Core.Entities;

public class Order
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; } = new Client();
    public ICollection<Book> Book { get; set; } = new List<Book>();
}
