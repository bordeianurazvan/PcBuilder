using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/storages")]
    [Produces("application/json")]
    public class StoragesController : Controller
    {
        private readonly IStorageRepository _repository;
        public StoragesController(IStorageRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<Storage>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{storageId}")]
        public async Task<Storage> GetById(Guid storageId)
        {
            return await _repository.GetByIdAsync(storageId);
        }

        [HttpPost]
        public async Task<Storage> Insert([FromBody] Storage storage)
        {
            return await _repository.InsertAsync(storage);

        }
    }
}