using Microsoft.EntityFrameworkCore;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Smile> Smiles => Set<Smile>();
        public DbSet<Emotion> Tags => Set<Emotion>();
        public DbSet<User> Users => Set<User>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}
