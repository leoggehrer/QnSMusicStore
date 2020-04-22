using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QnSMusicStore.Logic.Entities.Persistence.App;

namespace QnSMusicStore.Logic.DataContext.Db
{
    partial class QnSMusicStoreDbContext
    {
        partial void ConfigureEntityType(EntityTypeBuilder<Genre> entityTypeBuilder)
        {
            entityTypeBuilder
                .HasIndex(p => p.Name)
                .IsUnique();

            entityTypeBuilder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(256);
        }
        partial void ConfigureEntityType(EntityTypeBuilder<Artist> entityTypeBuilder)
        {
            entityTypeBuilder
                .HasIndex(p => p.Name)
                .IsUnique();
            entityTypeBuilder
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(1024);
        }
        partial void ConfigureEntityType(EntityTypeBuilder<Album> entityTypeBuilder)
        {
            entityTypeBuilder
                .HasIndex(p => p.Title)
                .IsUnique();
            entityTypeBuilder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(1024);
        }
        partial void ConfigureEntityType(EntityTypeBuilder<Track> entityTypeBuilder)
        {
            entityTypeBuilder
                .HasIndex(p => p.Title);
            entityTypeBuilder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(1024);
            entityTypeBuilder
                .Property(p => p.Composer)
                .HasMaxLength(512);
        }
    }
}
