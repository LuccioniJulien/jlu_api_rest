using AutoMapper;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;

namespace jlu_api_rest.Domain.Mapper
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<PostAuthorDto, Author>().ReverseMap();
        }
    }
}
