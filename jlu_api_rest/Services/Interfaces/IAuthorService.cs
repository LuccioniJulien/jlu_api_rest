using System.Threading.Tasks;
using jlu_api_rest.Domain.Dto;

namespace jlu_api_rest.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorDto> Create(PostAuthorDto author);
        Task<AuthorDto> Read(string name);

        Task<PostAuthorDto> Update(int id);
    }
}
