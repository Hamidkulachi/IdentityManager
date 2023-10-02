using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreManager.Data
{
    public class ApplicationDb:IdentityDbContext
    {
        public ApplicationDb(DbContextOptions options):base(options)
        {
                
        }
    }
}
