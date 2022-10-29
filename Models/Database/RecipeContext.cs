using Microsoft.EntityFrameworkCore;
namespace WebRecipe.Models;

public class RecipeContext : DbContext {

    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Category> Categories { get; set; }

    public RecipeContext(DbContextOptions<RecipeContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfiguration(new SeedRecipe());
        modelBuilder.ApplyConfiguration(new SeedCategory());

        modelBuilder.Entity<Recipe>()
                                     .HasOne(r => r.Category)
                                     .WithMany(c => c.Recipes);

    }
}