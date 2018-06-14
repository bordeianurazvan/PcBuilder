using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/rams")]
    [Produces("application/json")]
    public class RamsController : Controller
    {
        private readonly IRamRepository _repository;
        public RamsController(IRamRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Ram>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{ramId}")]
        public async Task<Ram> GetById(Guid ramId)
        {
            return await _repository.GetByIdAsync(ramId);
        }

        [HttpPost]
        public async Task<Ram> Insert([FromBody] Ram ram)
        {
            return await _repository.InsertAsync(ram);

        }
    }
}