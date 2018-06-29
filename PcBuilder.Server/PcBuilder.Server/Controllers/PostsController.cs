using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Core.Domain;
using Data.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PcBuilder.Server.Controllers
{
    [Route("api/posts")]
    [Produces("application/json")]
    public class PostsController : Controller
    {
        private readonly IPostRepository _repo;

        public PostsController(IPostRepository repository)
        {
            _repo = repository;
        }

        [HttpGet]
        public async Task<List<Post>> Get()
        {
            return await _repo.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Post> GetById(Guid id)
        {
            return await _repo.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<Post> Insert([FromBody] Post post)
        {
            return await _repo.InsertAsync(post);
        }

    }
}