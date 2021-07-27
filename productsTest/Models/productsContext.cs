using Microsoft.EntityFrameworkCore;

namespace productsTest.Models
{
    public class productContext : DbContext
    {
        public DbSet<products> Products { get; set; }


        public productContext(DbContextOptions<productContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>().ToTable("Table");
        }
    }
}