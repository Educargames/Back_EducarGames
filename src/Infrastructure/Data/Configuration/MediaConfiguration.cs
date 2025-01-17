using Educar.Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Educar.Backend.Infrastructure.Data.Configuration;

public class MediaConfiguration(DatabaseFacade database) : IEntityTypeConfiguration<Media>
{
    private readonly DatabaseFacade _database = database;

    public void Configure(EntityTypeBuilder<Media> builder)
    {
        builder.Property(t => t.Name).IsRequired().HasMaxLength(100);
        builder.Property(t => t.ObjectName).IsRequired();
        builder.Property(t => t.Url).IsRequired();
        builder.Property(t => t.Purpose).IsRequired().HasConversion<string>();
        builder.Property(t => t.Type).IsRequired().HasConversion<string>();
        builder.Property(t => t.Author).HasMaxLength(100);
        builder.Property(t => t.Agreement).IsRequired();

        builder
            .HasMany(g => g.QuestStepMedias)
            .WithOne(gs => gs.Media)
            .HasForeignKey(gs => gs.MediaId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}