using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoCardsController : Controller
    {
        private readonly IVideoCardRepository _repository;
        public VideoCardsController(IVideoCardRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<List<VideoCard>> Get(string filterObject)
        {
            var productFilter = new ProductFilter(filterObject);
            return await _repository.GetAllAsync(productFilter);
        }

        [HttpGet("{videoCardId}")]
        public async Task<VideoCard> GetById(Guid videoCardId)
        {
            return await _repository.GetByIdAsync(videoCardId);
        }

        [HttpPost]
        public async Task<VideoCard> Insert([FromBody] VideoCard videoCard)
        {
            return await _repository.InsertAsync(videoCard);

        }
    }
}