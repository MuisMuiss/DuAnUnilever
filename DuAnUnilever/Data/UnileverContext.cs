using DuAnUnilever.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAnUnilever.Data
{
    public class UnileverContext : DbContext
    {
        public UnileverContext(DbContextOptions<UnileverContext> options)
            : base(options)
        {
        }
        public DbSet<User>? Users { get; set; }
    }
}
