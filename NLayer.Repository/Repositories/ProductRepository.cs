using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Service.Services;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            //Eager Loading  => Productlar cekilirken categorylerinde gelmesini saglar
            // Lazy loading => Product a bagli categoryleri DAHA SONRA cekersen

            // eager loading 

            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
