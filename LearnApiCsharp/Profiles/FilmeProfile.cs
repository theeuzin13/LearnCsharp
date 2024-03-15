using AutoMapper;
using FilmesApi.Models;
using LearnApiCsharp.Data.DTOs;

namespace LearnApiCsharp.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>(); 
        CreateMap<Filme, ReadFilmeDto>(); 
    }
}
