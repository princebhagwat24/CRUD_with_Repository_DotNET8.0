using CRUDWithRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithRepository.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            // Check if the database already has data
            if (context.Products.Any())
            {
                return; // Database has been seeded
            }

            // Add initial data
            context.Products.AddRange(
                new Product
                {
                    Name = "Laptop",
                    Description = "A high-performance laptop.",
                    Price = 1200.00m
                },
                new Product
                {
                    Name = "Smartphone",
                    Description = "A flagship smartphone.",
                    Price = 800.00m
                },
                new Product
                {
                    Name = "Headphones",
                    Description = "Noise-cancelling headphones.",
                    Price = 200.00m
                }
            );

            context.SaveChanges();
        }
    }
}
