using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            { 
                Id = 2,
                Name = "Name02",
                Price = new decimal (69.9),
                Description= "Description ID2",
                ImageURL= "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                CategoryName= "T-shirt",

            });            
            modelBuilder.Entity<Product>().HasData(new Product
            { 
                Id = 3,
                Name = "Name03",
                Price = new decimal (69.9),
                Description= "Description ID3",
                ImageURL= "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                CategoryName= "T-shirt",

            });            
            modelBuilder.Entity<Product>().HasData(new Product
            { 
                Id = 4,
                Name = "Name04",
                Price = new decimal (69.9),
                Description= "Description ID4",
                ImageURL= "C:\\Users\\LeandroAvila\\Downloads\\ShoppingImages\\1_super_mario.jpg",
                CategoryName= "T-shirt",

            });
        }
    }
}
