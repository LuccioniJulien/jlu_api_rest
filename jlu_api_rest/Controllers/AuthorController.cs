using AutoMapper;
using jlu_api_rest.Api.Models;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;
using jlu_api_rest.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using jlu_api_rest.Global;

namespace jlu_api_rest.Controllers
{
    [ApiController]
    [Route($"{Variable.BaseApi}/[controller]")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService AuthorService { get; }

        public AuthorController(IAuthorService authorService)
        {
            AuthorService = authorService;
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<ResultData<AuthorDto>>> Get([Required] string name)
        {
            var author = await AuthorService.Read(name);
            if (author == null) return NotFound();
            var value = new ResultData<AuthorDto>
            {
                Data = null
            };
            return Ok(value);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post(PostAuthorDto author)
        {
            await AuthorService.Create(author);
            return Created("/Author", null);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id)
        {
            return null;
        }
    }
}