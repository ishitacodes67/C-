// CRUD using Entity Framework Core
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace CRUD_Entity_Framework_Core
{
    // Define the Product entity
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    // Define the DbContext
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ProductsDb");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Create
                var product = new Product { Name = "Laptop", Price = 999.99m };
                context.Products.Add(product);
                context.SaveChanges();

                // Read
                var products = context.Products.ToList();
                Console.WriteLine("Products:");
                foreach (var p in products)
                {
                    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}");
                }

                // Update
                var existingProduct = context.Products.FirstOrDefault(p => p.Name == "Laptop");
                if (existingProduct != null)
                {
                    existingProduct.Price = 899.99m;
                    context.SaveChanges();
                }

                // Delete
                var productToDelete = context.Products.FirstOrDefault(p => p.Name == "Laptop");
                if (productToDelete != null)
                {
                    context.Products.Remove(productToDelete);
                    context.SaveChanges();
                }
            }
        }
    }
}
