using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

namespace Intelificio_Back.Models
{
    public class Role : IdentityRole<int>
    {
        public required string Name { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
