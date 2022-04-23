using CitiesWeb.Database.models;
using Microsoft.EntityFrameworkCore;

namespace CitiesWeb.Database.contexts
{
    public class CityContext:DbContext
    {
        private static CityContext instance;
        public DbSet<City> cities { get; set; }
        public DbSet<Coordinates> coordinates { get; set; }

        public CityContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<City>()
                .HasOne(c => c.coords)
                .WithOne(c => c.city);*/
            base.OnModelCreating(modelBuilder);
        }
    }
}
