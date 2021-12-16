using System.Threading.Tasks;
using AutoMapper;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;
using jlu_api_rest.Services.Interfaces;

namespace jlu_api_rest.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IMapper _mapper;
        private readonly PfContext _context;

        public AuthorService(IMapper mapper, PfContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<AuthorDto> Create(PostAuthorDto author)
        {
            var authorToAdd = _mapper.Map<Author>(author);
            await _context.Author.AddAsync(authorToAdd);
            await _context.SaveChangesAsync();
            return null;
        }

        public AuthorDto Read(string name)
        {
            Author me = new() {Id = 1, Firstname = "Luccioni", LastName = "Julien", Age = 28};
            return me != null ? _mapper.Map<AuthorDto>(me) : null;
        }
    }
}