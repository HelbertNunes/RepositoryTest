using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteNava.Domain.Models;

namespace TesteNava.Domain.Interfaces.Service
{
    public interface ISaleService
    {
        void CrateInitialRegisters();
        Task<Tuple<bool, string>> RegisterSale(Sale sale);
        Task<Tuple<bool, string, Sale>> UpdateStatus(Sale sale, string newStatus);
    }
}
