using Microsoft.EntityFrameworkCore;

namespace SimpleDuelApi.Data
{
    public class DuelDbContext : DbContext
    {
        public DuelDbContext(DbContextOptions<DuelDbContext> options) : base(options){}
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Villian> Villians { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Weakness> Weaknesses { get; set; }
    }
}