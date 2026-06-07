using Microsoft.EntityFrameworkCore;
using ThreeDShopping.API.Models;

namespace ThreeDShopping.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Sprint 2 Additions
        public DbSet<CartItem> CartItems { get; set; }
    }
}