namespace API.Dtos;

public class ClientDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int PostalCode { get; set; }
    public string Country { get; set; } = string.Empty;
    public int Phone { get; set; }
}
