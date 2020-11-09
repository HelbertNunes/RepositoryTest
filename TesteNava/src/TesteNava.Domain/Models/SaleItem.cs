using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class SaleItem : Entity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
