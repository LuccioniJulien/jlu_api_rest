using Microsoft.EntityFrameworkCore;

namespace jlu_api_rest.Database;

public class PfContext : DbContext
{
    public PfContext(DbContextOptions context) : base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthorExperience>().HasKey(x => new {x.IdAuthor, x.IdExperience});
    }

    public DbSet<Author> Author { get; set; }
    public DbSet<Experience> Experience { get; set; }
    public DbSet<Tag> Tag { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<AuthorExperience> AuthorExperience { get; set; }
}