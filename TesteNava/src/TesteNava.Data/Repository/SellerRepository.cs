using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Data.Context;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Models;

namespace TesteNava.Data.Repository
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        public SellerRepository(TesteNavaDbContext context) : base(context) { }
    }
}
