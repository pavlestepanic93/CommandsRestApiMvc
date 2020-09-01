using AutoMapper;
using CommanderNew.Dtos;
using CommanderNew.Models;

namespace CommanderNew.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Mapping: Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}