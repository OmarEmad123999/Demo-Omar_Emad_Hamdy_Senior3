using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ArtPiece> Pieces { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasOne(x=> x.LoyaltyCard).WithOne(x=> x.Customer).HasForeignKey<LoyaltyCard>(x=> x.CustomerId);
            modelBuilder.Entity<Category>().HasMany(x => x.Pieces).WithMany(x => x.Categories);
            modelBuilder.Entity<Customer>().HasMany(x=> x.ArtPieces).WithOne(x=> x.Customer).HasForeignKey(x=> x.CustomerId);

            modelBuilder.Entity<Customer>().HasData(
                  new Customer { Id=1, Name="Omar" , Email ="omar.052302@gmail.com", Phone="012293215"},
                   new Customer { Id = 2, Name = "Ahmed", Email = "ahmed@gmail.com", Phone = "012293288" },
                    new Customer { Id = 3, Name = "Kareem", Email = "kareem@gmail.com", Phone = "0125899" }
                );

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id=1, Name="Arts"},
                 new Category { Id=2 ,Name="Photoes"}
                );
            modelBuilder.Entity<LoyaltyCard>().HasData(
                new LoyaltyCard { Id=1 , Balance=555, CardNumber="1a1", CustomerId=1 },
                new LoyaltyCard { Id = 2, Balance = 1000, CardNumber = "22a", CustomerId = 2}
                );
            modelBuilder.Entity<ArtPiece>().HasData(
                 new ArtPiece { Id=1, Title="Sheks", Description="Egyptian art", Price=250, CustomerId=2 },
                  new ArtPiece { Id = 2, Title = "Monor", Description = "French art", Price = 500, CustomerId = 3 }
                );
        }
    }
}
