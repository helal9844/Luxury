using Luxury_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Luxury_Back.DB
{
    public class LuxuryDb : DbContext
    {
        public virtual DbSet<User> users { get; set; } = null!;
        public virtual DbSet<Governorate> governorates { get; set; } = null!;
        public virtual DbSet<City> cities { get; set; } = null!;
        public virtual DbSet<Category> categories { get; set; } = null!;
        public virtual DbSet<CategoryTranslation> categoriesTranslation { get; set; } = null!;
        public LuxuryDb(DbContextOptions<LuxuryDb> dbContextOptions) : base(dbContextOptions)
        {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>().HasKey(a => a.Id);
            modelBuilder.Entity<User>().Property(b => b.password);
            /*modelBuilder.Entity<User>().Property(b => b.username)
                        .HasColumnType("varchar(max)")
                        .UseCollation("ARABIC_CI_AS")
                        .IsUnicode();*/

            //Governorate
            modelBuilder.Entity<Governorate>().ToTable("governorates");
            /*modelBuilder.Entity<Governorate>().Property(g => g.name_ar)
                        .HasColumnType("varchar(max)")
                        .UseCollation("ARABIC_CI_AS")
                        .IsUnicode();*/

           //City
           modelBuilder.Entity<City>().ToTable("cities");
            /*modelBuilder.Entity<City>().Property(g => g.name_ar)
                        .HasColumnType("varchar(max)")
                        .UseCollation("ARABIC_CI_AS")
                        .IsUnicode();*/

            modelBuilder.Entity<Category>()
                .HasMany(c => c.translations)
                .WithOne();
        }
    }
}
