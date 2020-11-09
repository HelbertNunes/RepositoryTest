using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNava.Domain.Models;

namespace TesteNava.API.ViewModels
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public DateTime SaleDate { get; set; }
        public string Status { get; set; }
        public SellerViewModel Seller { get; set; }
        public IEnumerable<SaleItemViewModel> SaleItems { get; set; }
    }
}
