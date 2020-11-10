using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TesteNava.API.ViewModels;
using TesteNava.Domain.Interfaces;
using TesteNava.Domain.Interfaces.Service;
using TesteNava.Domain.Models;

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
        }
        // GET: api/SalesController
        [HttpGet]
        public async Task<IEnumerable<SaleViewModel>> GetAllSales()
        {
            return _mapper.Map<IEnumerable<SaleViewModel>>(await _saleRepository.GetAll());
        }

        // GET api/Sales/Guid
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<SaleViewModel>> GetSaleById(Guid id)
        {
            var sale = _mapper.Map<SaleViewModel>(await _saleRepository.GetById(id));
            if (sale == null) return NotFound();

            return sale;
        }

        // POST api/SalesController
        [HttpPost]
        public async Task<ActionResult<SaleViewModel>> AddSale([FromBody] SaleViewModel saleViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();
            var sale = _mapper.Map<Sale>(saleViewModel);

            //await _saleService.RegisterSale(sale);
            return Ok(saleViewModel);
        }

        // PUT api/Sales/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Sales/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        //Endpoint apenas para adicionar registros de teste no banco em memória
        [HttpGet("CreateRegisters")]
        public ActionResult CreateRegisters()
        {
            _saleService.CrateInitialRegisters();
            return Ok();
        }
    }
}
