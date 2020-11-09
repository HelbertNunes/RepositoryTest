using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteNava.Data.Context;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Repository
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        public SaleRepository(TesteNavaDbContext context) : base(context) { }
        public override Task<List<Sale>> GetAll()
        {
            return DbSet.Where(s => s.Id != null)
                .Include("SaleItems")
                .Include("Seller.Sales").ToListAsync();
        }
    }
}
