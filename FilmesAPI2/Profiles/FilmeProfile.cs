using AutoMapper;
using FilmesAPI2.Data.Dtos;
using FilmesAPI2.Models;

namespace FilmesAPI2.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
