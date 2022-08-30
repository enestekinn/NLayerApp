using NLayer.Core.Models;
using NLayer.Core.Repository;

namespace NLayer.Service.Services
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<List<Product>> GetProductWithCategory();
    }
}
