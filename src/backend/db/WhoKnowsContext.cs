
// src/backend/db/WhoKnowsContext.cs
using Microsoft.EntityFrameworkCore;
using whoknows_c_sharp.domains.pages;
using whoknows_c_sharp.domains.users;
namespace whoknows_c_sharp.db;

public class WhoKnowsContext : DbContext
{
    public WhoKnowsContext(DbContextOptions<WhoKnowsContext> options) : base(options) { }

    public DbSet<Page> Pages { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Page configuration
        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => e.Title);
            entity.Property(e => e.Url).IsRequired();
            entity.Property(e => e.Language)
                .IsRequired()
                .HasDefaultValue("en");
            entity.Property(e => e.Content).IsRequired();
        });

        // User configuration
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Username).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Password).IsRequired();

            entity.HasIndex(e => e.Username).IsUnique();
            entity.HasIndex(e => e.Email).IsUnique();
        });
    }
}
