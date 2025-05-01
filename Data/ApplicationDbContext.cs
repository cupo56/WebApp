using iScent.Models;
using Microsoft.EntityFrameworkCore;

namespace iScent.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Parfum> Parfums { get; set; }
    }
}
