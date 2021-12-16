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
        public ActionResult<Result<AuthorDto>> Get([Required] string name)
        {
            var author = AuthorService.Read(name);
            if (author == null) return NotFound();
            return Ok(new Result<AuthorDto> { Data = null });
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post(PostAuthorDto author)
        {
            await AuthorService.Create(author);
            return Created("/", null);
        }

    }
}