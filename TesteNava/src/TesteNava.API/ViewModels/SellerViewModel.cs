using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteNava.API.ViewModels
{
    public class SellerViewModel
    {
        public Guid Id { get; set; }
        public int Cpf { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<SaleViewModel> Sales { get; set; }
    }
}
