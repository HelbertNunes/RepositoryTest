using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TesteNava.API.ViewModels;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Interfaces.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TesteNava.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _saleService;
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        public SalesController(ISaleRepository saleRepository, IMapper mapper, ISaleService saleService)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
            _saleService = saleService;
            _saleService.CrateInitialRegisters();
        }
        // GET: api/<SalesController>
        [HttpGet]
        public async Task<IEnumerable<SaleViewModel>> GetAllSales()
        {
            var allSales = _mapper.Map<IEnumerable<SaleViewModel>>( await _saleRepository.GetAll());
            return allSales;
        }

        // GET api/<SalesController>/5
        [HttpGet("{id:guid}")]
        public string GetSaleById(Guid id)
        {
            return "value";
        }

        // POST api/<SalesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
