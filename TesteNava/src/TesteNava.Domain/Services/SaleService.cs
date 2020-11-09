using System;
using System.Collections.Generic;
using System.Text;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Interfaces.Service;
using TesteNava.Domain.Models;

namespace TesteNava.Domain.Services
{
    public class SaleService : ISaleService
    {
        protected readonly ISaleRepository _saleRepository;
        protected readonly ISaleItemRepository _saleItemRepository;
        protected readonly ISellerRepository _sellerRepository;

        public SaleService(ISaleRepository saleRepository, ISellerRepository sellerRepository, ISaleItemRepository saleItemRepository)
        {
            _saleRepository = saleRepository;
            _saleItemRepository = saleItemRepository;
            _sellerRepository = sellerRepository;
        }
        public void CrateInitialRegisters()
        {
            var sellerTest = new Seller("11122233344", "Vendedor Teste", "vendedor@teste", "31945682354");
            var saleTest = new Sale(sellerTest, "Aguardando Pagamento", DateTime.Today.Date);
            var itemTest = new SaleItem("item", 9.90, saleTest);
            saleTest.AddItems(new List<SaleItem> { itemTest });
            sellerTest.AddSale(saleTest);

            _sellerRepository.Add(sellerTest);
            _sellerRepository.SaveChanges();

            _saleItemRepository.Add(itemTest);
            _saleItemRepository.SaveChanges();

            _saleRepository.Add(saleTest);
            _saleRepository.SaveChanges();            
        }
    }
}
