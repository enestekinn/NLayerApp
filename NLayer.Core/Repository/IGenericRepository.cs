using System.Linq.Expressions;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        // neden IEnumerable donmuyoruz?
        // productRepository.GetAll(x=>x.id>5).ToList() tolist dedigimz anda db ye sorguyu atar
        IQueryable<T> GetAll();

        //productRepository.where(x => x.id >5 ).OrderBy.ToListAsync()
        // eger IQueryable yerine List kullanilirsa where ifadesini yazdiktan sonra datayi ceker memory'e alir daha sonra orderby komutunu calistirir.
        // Expression<Func<T,bool> nedir T entity alacak x mesela bool ise yukaridaki gibi 5 den buyuk mu degil bir deger donecek
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);


        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
