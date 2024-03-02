using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Order");

        builder.Property(p => p.Id)
            .IsRequired();

        builder.HasOne(p => p.Client)
                .WithMany(p => p.Order)
                .HasForeignKey(p => p.ClientId);
    }
}
