using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EMS_Tool.Areas.Identity.Data;

namespace EMS_Tool.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ✅ Here is where you define DbSet<UserProject> in the context
        public DbSet<UserProject> UserProjects { get; set; }
    }
}

