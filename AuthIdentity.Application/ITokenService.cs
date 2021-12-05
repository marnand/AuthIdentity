using System.Threading.Tasks;
using AuthIdentity.Application.DTO;

namespace AuthIdentity.Application
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDTO userUpdateDTO);
    }
}