using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class SaleItem : Entity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
    }
}
