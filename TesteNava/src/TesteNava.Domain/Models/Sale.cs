using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNava.Domain.Models
{
    public class Sale: Entity
    {
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
        public string Status { get; set; }
        public IEnumerable<SaleItem> SaleItems { get; set; }
    }
}
