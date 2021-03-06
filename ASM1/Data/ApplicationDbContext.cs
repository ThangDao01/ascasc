using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASM1.Models;

namespace ASM1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASM1_v2.Models.Category> Category { get; set; }
        public DbSet<ASM1_v2.Models.Product> Product { get; set; }
    }
}
