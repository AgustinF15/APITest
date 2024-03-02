﻿namespace Core.Entities;

public class Order : BaseEntity
{
    public int ClientId { get; set; }
    public Client Client { get; set; } = new Client();
    public ICollection<Book> Book { get; set; } = new List<Book>();
}
