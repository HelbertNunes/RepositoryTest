using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Mappings
{
    public class SellerMapping : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.Property(s => s.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Cpf)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.Property(s => s.PhoneNumber)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.HasMany(s => s.Sales)
                .WithOne(s => s.Seller)
                .HasForeignKey(s => s.SellerId);

            builder.ToTable("Sellers");
        }
    }
}
