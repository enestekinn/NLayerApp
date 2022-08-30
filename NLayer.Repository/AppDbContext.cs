using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }



        // ProductFeature product a bagli bir nesne o yuzden yeni ProductFeatures table i dogrudan olusturmak yerine 
        // Her product olusturuldugunda   ProductFeatures olusturabiliriz
        //ProductFeatures bagimsiz eklenmemeli
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // tum configuration dostasini okuyor
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            // tek tek okumak icin
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Entity<ProductFeature>().HasData(
                new
                {
                    Id = 1,
                    Color = "Kirmizi",
                    Height = 100,
                    Width = 200,
                    ProductId = 1
                },
                        new
                        {
                            Id = 2,
                            Color = "Mavi",
                            Height = 50,
                            Width = 100,
                            ProductId = 2
                        }
                
                
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
