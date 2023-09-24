using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context(DbContextOptions<WebApplication1Context> options)
            : base(options) { }

        public DbSet<OpenUsers> openUsers { get; set; }
        public DbSet<CreateUsers> createUsers { get; set; }
        public DbSet<OrganizationScores> organizationScores { get; set; }
    }
}
