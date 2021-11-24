using AutoMapper;
using jlu_api_rest.Api.Models;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace jlu_api_rest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IMapper _mapper;
        public AuthorController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("{name}")]
        public ActionResult<Result<AuthorDto>> Get(string name)
        {
            Author me = new() { Id = 1 , Firstname = "Luccioni" , LastName = "Julien" , Age = 28 };
            return new Result<AuthorDto> { Data = _mapper.Map<AuthorDto>(me) };
        }

    }
}