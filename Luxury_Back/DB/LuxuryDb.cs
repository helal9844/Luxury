using Luxury_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Luxury_Back.DB
{
    public class LuxuryDb : DbContext
    {
        /*public virtual DbSet<Language> languages { get; set; }*/
        public virtual DbSet<User> users { get; set; } = null!;
        public virtual DbSet<Governorate> governorates { get; set; } = null!;
        public virtual DbSet<City> cities { get; set; } = null!;
        public virtual DbSet<Category> categories { get; set; } = null!;
        public virtual DbSet<IBooking> iBookings { get; set; } = null!;

        public virtual DbSet<Address> addresses { get; set; } = null!;

        public virtual DbSet<IBookingImg> iBookingImg { get; set; } = null!;
        //public virtual DbSet<CategoryTranslation> categoriesTranslation { get; set; } = null!;
        public LuxuryDb(DbContextOptions<LuxuryDb> dbContextOptions) : base(dbContextOptions)
        {
            /*Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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

            //Booking
            modelBuilder.Entity<IBooking>().ToTable("iBookings");
            modelBuilder.Entity<IBooking>().Property(b => b.created_at).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Category>()
                .HasMany(c => c.iBookings)
                .WithOne(b => b.Category)
                .HasForeignKey(b=>b.Category_Id);

            //Address
            modelBuilder.Entity<Address>().HasOne(h => h.IBooking).WithOne(b => b.Address);

            //IBookingImages
            modelBuilder.Entity<IBooking>()
               .HasMany(c => c.images)
               .WithOne(b => b.booking)
               .HasForeignKey(b => b.IBookingId);

            /*modelBuilder.Entity<Category>()
                .HasMany(c => c.translations)
                .WithOne();*/

            //Languages
            /*modelBuilder.Entity<Language>().ToTable("languages");
            modelBuilder.Entity<Language>().HasKey(a => a.Id);*/
        }
    }
}
