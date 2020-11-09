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
        public DateTime SaleDate { get; set; }
        public List<SaleItem> SaleItems { get; set; }

        public Sale(){}
        public Sale(Seller seller, string status, DateTime saleDate)
        {
            Seller = seller;
            SellerId = seller.Id;
            Status = status;
            SaleDate = saleDate;
            SaleItems = new List<SaleItem>();
        }
        public void AddItems(IEnumerable<SaleItem> saleItems)
        {
            SaleItems.AddRange(saleItems);
        }
    }
}
