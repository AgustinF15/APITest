using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Book");

        builder.Property(p => p.Id)
            .IsRequired();

        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.Author)
           .IsRequired()
           .HasMaxLength(100);

        builder.Property(p => p.Category)
           .IsRequired()
           .HasMaxLength(100);

        builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

        builder.HasOne(p => p.Order)
                .WithMany(p => p.Book)
                .HasForeignKey(p => p.OrderId);
    }
}
