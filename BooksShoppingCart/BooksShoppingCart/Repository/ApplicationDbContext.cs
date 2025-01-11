using BooksShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksShoppingCart.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImage{ get; set; }


    }
}
