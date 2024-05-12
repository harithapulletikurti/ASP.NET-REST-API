using Microsoft.EntityFrameworkCore;
namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ActiveWear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Men Blue Activeware", IsAvailable = true},
                new Product { Id = 2, CategoryId = 1, Name = "Men Black Activeware", IsAvailable = false },
                new Product { Id = 3, CategoryId = 1, Name = "Men Red Activeware"  ,IsAvailable = true },
                new Product { Id = 4, CategoryId = 2, Name = "Women Blue Activeware", IsAvailable = true },
                new Product { Id = 5, CategoryId = 2, Name = "Women Black Activeware" , IsAvailable = false },
                new Product { Id = 6, CategoryId = 2, Name = "Women Red Activeware" ,IsAvailable = true,  },
                new Product { Id = 7, CategoryId = 3, Name = "Bisleri" , IsAvailable = true },
                new Product { Id = 8, CategoryId = 3, Name = "Ganga"   , IsAvailable = false },
                new Product { Id = 9, CategoryId = 3, Name = "Mineral water" , IsAvailable = true },
                new Product { Id = 10, CategoryId = 4, Name = "Publications1 ", IsAvailable = false },
                new Product { Id = 11, CategoryId = 4, Name = "Publications2" , IsAvailable = true },
                new Product { Id = 12, CategoryId = 4, Name = "Publications3", IsAvailable = false },
                new Product { Id = 13, CategoryId = 5, Name = "Vitamin A" , IsAvailable = true },
                new Product { Id = 14, CategoryId = 5, Name = "Vitamin B" , IsAvailable = false},
                new Product { Id = 15, CategoryId = 5, Name = "Vitamin C" , IsAvailable= true});
        }
    }
}
