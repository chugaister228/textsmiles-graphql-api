using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Data.Configurations
{
    public class EmotionConfiguration : IEntityTypeConfiguration<Emotion>
    {
        public void Configure(EntityTypeBuilder<Emotion> builder)
        {
            builder.
                HasKey(e => e.ID);

            builder
                .Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

            builder
                .Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
