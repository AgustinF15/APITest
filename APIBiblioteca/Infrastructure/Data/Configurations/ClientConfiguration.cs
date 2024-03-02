using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("Client");

        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.LastName) 
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Address)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.City) 
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.PostalCode)
            .IsRequired();

        builder.Property(p => p.Country)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Phone)
            .IsRequired();
    }
}
