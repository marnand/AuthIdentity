using AuthIdentity.Application.DTO;
using AuthIdentity.Domain.Identity;
using AutoMapper;

namespace AuthIdentity.Application.Mapping
{
    public class AuthIdentityMapping : Profile
    {
        public AuthIdentityMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserLoginDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
        }
    }
}