using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Data.Context;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Repository
{
    public class SaleItemRepository : Repository<SaleItem>, ISaleItemRepository
    {
        public SaleItemRepository(TesteNavaDbContext context) : base(context) { }
    }
}
