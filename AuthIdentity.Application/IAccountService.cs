using System.Threading.Tasks;
using AuthIdentity.Application.DTO;
using Microsoft.AspNetCore.Identity;

namespace AuthIdentity.Application
{
    public interface IAccountService 
    {
        Task<SignInResult> CheckUserPasswordAsync(UserUpdateDTO userUpdateDto, string password);

        Task<UserUpdateDTO> CreateAccountAsync(UserDTO userDto);

        Task<UserUpdateDTO> GetUserByUserNameAsync(string username);

        Task<UserUpdateDTO> UpdateAccount(UserUpdateDTO userUpdateDTO);
        
        Task<bool> UserExists(string username);
    }
}