using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteNava.Domain.Models;

namespace TesteNava.API.ViewModels
{
    public class SaleItemViewModel
    {
        Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public IEnumerable<SaleViewModel> Sales { get; set; }
    }
}
