namespace RePro.Infrastructure.EntityFrameworkDataAccess {
    using Microsoft.EntityFrameworkCore;
    using Entities;
    public sealed class ReProDBContext : DbContext
    {
        public ReProDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Seller> Sellers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Seller>()
                .ToTable("Seller");
        }

    }
}