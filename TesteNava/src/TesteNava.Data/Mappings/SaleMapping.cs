using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Mappings
{
    public class SaleMapping : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.Id);

            builder.HasMany(s => s.SaleItems)
                .WithOne(i => i.Sale)
                .HasForeignKey(isa => isa.SaleId);

            builder.ToTable("Sales");
        }
    }
}
