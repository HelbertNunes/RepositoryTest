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
        public IEnumerable<SaleItem> SaleItems { get; set; }

        public Sale(){}
        public Sale(Seller seller, string status, DateTime saleDate)
        {
            Seller = seller;
            SellerId = seller.Id;
            Status = status;
            SaleDate = saleDate;
            
        }
        public void AddItems(IEnumerable<SaleItem> saleItems)
        {
            SaleItems = saleItems;
        }
    }
}
