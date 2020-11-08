using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    class Sale: Entity
    {
        public Seller Seller { get; set; }
        public IEnumerable<SaleItem> SaleItems { get; set; }
        public string Status { get; set; }
    }
}
