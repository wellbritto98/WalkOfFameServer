using AutoMapper;
using WalkOfFameServer.API.Dtos.Outgoing.User;
using WalkOfFameServer.Models.Users;

namespace WalkOfFameServer.API.Dtos.Incoming
{
    public class IncomingMapperProfile : Profile
    {
        public IncomingMapperProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
