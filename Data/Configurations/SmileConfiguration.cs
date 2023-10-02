using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextSmiles.API.Data.Entities;

namespace TextSmiles.API.Data.Configurations
{
    public class SmileConfiguration : IEntityTypeConfiguration<Smile>
    {
        public void Configure(EntityTypeBuilder<Smile> builder)
        {
            builder.
                HasKey(s => s.ID);

            builder
                .Property(s => s.ID)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

            builder
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(s => s.Text)
                .IsRequired();

            builder
                .HasOne(s => s.Emotion)
                .WithMany(e => e.Smiles)
                .HasForeignKey(s => s.EmotionID)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.User)
                .WithMany(e => e.Smiles)
                .HasForeignKey(s => s.UserID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
