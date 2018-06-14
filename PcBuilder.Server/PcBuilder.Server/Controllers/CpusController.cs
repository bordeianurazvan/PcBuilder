using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/cpus")]
    [Produces("application/json")]
    public class CpusController : Controller
    {
        private readonly ICpuRepository _repository;
        public CpusController(ICpuRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Cpu>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{cpuId}")]
        public async Task<Cpu> GetById(Guid cpuId)
        {
            return await _repository.GetByIdAsync(cpuId);
        }

        [HttpPost]
        public async Task<Cpu> Insert([FromBody] Cpu cpu)
        {
            return await _repository.InsertAsync(cpu);

        }

    }
}