using System.Collections.Generic;
using System.Threading.Tasks;
using AuthIdentity.Domain.Identity;
using AuthIdentity.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace AuthIdentity.Persistence 
{
    public class UserPersistence : BasePersistence, IUserPersistence
    {
        private readonly AuthIdentityContext _context;

        public UserPersistence(AuthIdentityContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users.SingleOrDefaultAsync(user => user.UserName.ToLower() == userName.ToLower());
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}