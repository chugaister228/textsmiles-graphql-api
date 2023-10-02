using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.
                HasKey(e => e.ID);

            builder
                .Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

            builder
                .Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
