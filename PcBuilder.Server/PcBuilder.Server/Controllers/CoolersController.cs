using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{

    [Route("api/coolers")]
    [Produces("application/json")]
    public class CoolersController : Controller
    {
        private readonly ICoolerRepository _repository;
        public CoolersController(ICoolerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Cooler>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{coolerId}")]
        public async Task<Cooler> GetById(Guid coolerId)
        {
            return await _repository.GetByIdAsync(coolerId);
        }

        [HttpPost]
        public async Task<Cooler> Insert([FromBody] Cooler cooler)
        {
            return await _repository.InsertAsync(cooler);

        }
    }
}