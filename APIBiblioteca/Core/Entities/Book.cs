namespace Core.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; } = new Order();
}
