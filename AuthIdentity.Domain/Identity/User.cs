using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace AuthIdentity.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}