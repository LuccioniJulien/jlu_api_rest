using AutoMapper;
using jlu_api_rest.Database;
using jlu_api_rest.Domain.Dto;

namespace jlu_api_rest.Domain.Mapper
{
    public class AuthorDtoProfile : Profile
    {
        public AuthorDtoProfile()
        {
            CreateMap<AuthorDto, Author>().ReverseMap();
        }
    }
}
