using AnimeAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeAsp.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<EpisodeModel> Episodes { get; set; }
        public DbSet<VideoModel> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Nhieu nhieu cua Movie va Category
            modelBuilder.Entity<MovieModel>()
                .HasMany(m => m.Categories)
                .WithMany(c => c.Movies)
                .UsingEntity(j => j.ToTable("MovieCategories"));

            modelBuilder.Entity<ProductModel>()
                .HasMany(p => p.categories)
                .WithMany(c => c.Products)
                .UsingEntity(j => j.ToTable("ProductCategories"));

            modelBuilder.Entity<EpisodeModel>()
                .HasMany(e => e.Videos)
                .WithMany(v => v.Episodes)
                .UsingEntity(j => j.ToTable("EpisodeVideos"));

            //mot nhieu cua Movie va Episode
            modelBuilder.Entity<MovieModel>()
                .HasMany(m => m.Episodes)
                .WithOne(e => e.Movie)
                .HasForeignKey(e => e.MovieId);
        }
    }
}