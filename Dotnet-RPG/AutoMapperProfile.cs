using AutoMapper;
using Dotnet_RPG.Dtos.Character;
using Dotnet_RPG.Models;

namespace Dotnet_RPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}