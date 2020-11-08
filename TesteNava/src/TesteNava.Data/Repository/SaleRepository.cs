using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Data.Context;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Repository
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(TesteNavaDbContext context) : base(context) { }
    }
}
