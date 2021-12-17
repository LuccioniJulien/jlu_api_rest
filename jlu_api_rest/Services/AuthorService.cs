using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;
using jlu_api_rest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public async Task<AuthorDto> Read(string name)
        {
            var me = await _context.Author.FirstOrDefaultAsync(x => x.Firstname == name);
            return me != null ? _mapper.Map<AuthorDto>(me) : null;
        }

        public Task<PostAuthorDto> Update(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}