using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/cases")]
    [Produces("application/json")]
    public class CasesController: Controller
    {
        private readonly ICaseRepository _repository;
        public CasesController(ICaseRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Case>> Get(string filterObject)
        {
           var productFilter = new ProductFilter(filterObject);
           return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{caseId}")]
        public async Task<Case> GetById(Guid caseId)
        {
            return await _repository.GetByIdAsync(caseId);
        }

        [HttpPost]
        public  async Task<Case> Insert([FromBody] Case computerCase)
        {
            return await _repository.InsertAsync(computerCase);

        }
    }
}
