using Microsoft.EntityFrameworkCore;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Emotion> Emotions { get; set; } = default!;
        public DbSet<Smile> Smiles { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}
