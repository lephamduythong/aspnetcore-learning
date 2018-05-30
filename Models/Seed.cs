using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SportStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
<<<<<<< HEAD
                    Name = "Kayak fix more",
=======
                    Name = "Kayak",
>>>>>>> d7556cd... Init: complete chapter 8
                    Description = "A boat for one person",
                    Category = "Watersports",
                    Price = 275
                },
                new Product
                {
                    Name = "Lifejacket",
                    Description = "Protective and fashionable",
                    Category = "Watersports",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Soccer Ball",
                    Description = "FIFA-approved size and weight",
                    Category = "Soccer",
                    Price = 19.50m
                },
                new Product
                {
<<<<<<< HEAD
                    Name = "Corner Flags 2",
                    Description = "Give your playing field a professional touch 2",
                    Category = "Soccer 2",
=======
                    Name = "Corner Flags",
                    Description = "Give your playing field a professional touch",
                    Category = "Soccer",
>>>>>>> d7556cd... Init: complete chapter 8
                    Price = 34.95m
                },
                new Product
                {
<<<<<<< HEAD
                    Name = "Á đù",
=======
                    Name = "Stadium",
>>>>>>> d7556cd... Init: complete chapter 8
                    Description = "Flat-packed 35,000-seat stadium",
                    Category = "Soccer",
                    Price = 79500
                },
                new Product
                {
                    Name = "Thinking Cap",
                    Description = "Improve brain efficiency by 75%",
                    Category = "Chess",
                    Price = 16
                },
                new Product
                {
                    Name = "Unsteady Chair",
                    Description = "Secretly give your opponent a disadvantage",
                    Category = "Chess",
                    Price = 29.95m
                },
                new Product
                {
<<<<<<< HEAD
                    Name = "Human Chess Board 2222",
=======
                    Name = "Human Chess Board",
>>>>>>> d7556cd... Init: complete chapter 8
                    Description = "A fun game for the family",
                    Category = "Chess",
                    Price = 75
                },
                new Product
                {
                    Name = "Bling-Bling King",
                    Description = "Gold-plated, diamond-studded King",
                    Category = "Chess",
                    Price = 1200
                }
                );
                context.SaveChanges();
            }
        }
    }
}