using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/motherboards")]
    [Produces("application/json")]
    public class MotherboardsController : Controller
    {
        private readonly IMotherboardRepository _repository;
        public MotherboardsController(IMotherboardRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Motherboard>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{motherboardId}")]
        public async Task<Motherboard> GetById(Guid motherboardId)
        {
            return await _repository.GetByIdAsync(motherboardId);
        }

        [HttpPost]
        public async Task<Motherboard> Insert([FromBody] Motherboard motherboard)
        {
            return await _repository.InsertAsync(motherboard);

        }
    }
}