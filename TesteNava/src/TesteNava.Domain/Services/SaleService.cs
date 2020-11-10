using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Interfaces.Service;
using TesteNava.Domain.Models;
using TesteNava.Domain.Utils;

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

        public async Task<Tuple<bool, string>> RegisterSale(Sale sale)
        {
            var validSaleTuple = ValidateSale(sale);

            if (!validSaleTuple.Item1)
            {
                return validSaleTuple;
            }

            sale.Status = Consts.WaitingPayment;
            await _saleRepository.Add(sale);
            await _saleRepository.SaveChanges();

            return validSaleTuple;
        }

        private Tuple<bool, string> ValidateSale(Sale sale)
        {
            var testSaleExists = _saleRepository.GetById(sale.Id).Result;
            var testSellerExists = _sellerRepository.GetById(sale.SellerId).Result;

            if (sale.Seller == null || sale.SellerId == null)
            {
                return new Tuple<bool, string>(false, Consts.NoSeller);
            }

            if (sale.SaleItems == null || !sale.SaleItems.Any())
            {
                return new Tuple<bool, string>(false, Consts.NoItems);
            }

            if (testSaleExists != null)
            {
                return new Tuple<bool, string>(false, Consts.SaleRegisteredAlready);
            }

            if (testSellerExists != null)
            {
                sale.Seller = testSellerExists;
            }

            return new Tuple<bool, string>(true, Consts.Ok);
        }

        public async Task<Tuple<bool, string, Sale>> UpdateStatus(Sale sale, string newStatus)
        {
            if (!Consts.StatusList.Contains(newStatus))
            {
                return new Tuple<bool, string, Sale>(false, Consts.StatusDontExistMessage, sale);
            }

            if (IsValidStatusChange(sale.Status, newStatus))
            {
                sale.Status = newStatus;
                await _saleRepository.Update(sale);
                await _saleRepository.SaveChanges();
                return new Tuple<bool, string, Sale>(true, Consts.Ok, sale);
            }

            return new Tuple<bool, string, Sale>(false, Consts.InvalidStatusChange, sale);
        }

        private bool IsValidStatusChange(string status, string newStatus)
        {
            if (status == Consts.WaitingPayment)
            {
                if (newStatus == Consts.PaymentApproved || newStatus == Consts.Canceled) return true;
            }

            if (status == Consts.PaymentApproved)
            {
                if (newStatus == Consts.SentToTransport || newStatus == Consts.Canceled) return true;
            }

            if (status == Consts.SentToTransport)
            {
                if (newStatus == Consts.Delivered) return true;
            }

            return false;
        }
    }
}
