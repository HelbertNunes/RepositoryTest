using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Mappings
{
    public class SaleItemMapping : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(i => i.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Sellers");
        }
    }
}
