using Microsoft.EntityFrameworkCore;

namespace ShootingRange.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}