using Microsoft.EntityFrameworkCore;

namespace TRY_KUET_WEBSITE.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TryKuetDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Donation> Donations { get; set; }
    }
}