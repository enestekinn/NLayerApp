using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            builder.HasData(
                new { Id = 1, Name = "Kalemler" },
                new { Id = 2, Name = "Kitaplar" },
                new { Id = 3, Name = "Defterler" }
                );
        }
    }
}
