using System.Collections.Generic;
using System.Threading.Tasks;
using AuthIdentity.Domain.Identity;

namespace AuthIdentity.Persistence 
{
    public interface IUserPersistence : IBasePersistence
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int id);
        
        Task<User> GetUserByUserNameAsync(string userName);
    }
}