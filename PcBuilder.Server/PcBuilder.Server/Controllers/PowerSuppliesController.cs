using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/powersupplies")]
    [Produces("application/json")]
    public class PowerSuppliesController : Controller
    {
        private readonly IPowerSupplyRepository _repository;
        public PowerSuppliesController(IPowerSupplyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<PowerSupply>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{powerSupplyId}")]
        public async Task<PowerSupply> GetById(Guid powerSupplyId)
        {
            return await _repository.GetByIdAsync(powerSupplyId);
        }

        [HttpPost]
        public async Task<PowerSupply> Insert([FromBody] PowerSupply powerSupply)
        {
            return await _repository.InsertAsync(powerSupply);

        }
    }
}