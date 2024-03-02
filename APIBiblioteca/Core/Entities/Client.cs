namespace Core.Entities;

public class Client : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int PostalCode { get; set; }
    public string Country { get; set; } = string.Empty;
    public int Phone { get; set; }
    public ICollection<Order> Order { get; set; } = new List<Order>();
}
