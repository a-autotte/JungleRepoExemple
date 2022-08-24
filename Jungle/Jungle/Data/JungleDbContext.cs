using Microsoft.EntityFrameworkCore;
using Jungle_Models.Models;

namespace Jungle.Data
{
    public class JungleDbContext : DbContext
    {
        public JungleDbContext(DbContextOptions<JungleDbContext> options) : base(options)
        {

        }

        public DbSet<TravelRecommendation> TravelRecommendation { get; set; }

        public DbSet<Destination> Destination { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Guide> Guide { get; set; }

        public DbSet<Travel> Travel { get; set; }

    }
}
