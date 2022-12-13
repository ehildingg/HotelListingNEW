namespace HotelListingNEW.api.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int?id);

        Task<List<T>> GetAllAsync();

        Task<T> AddSync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(int? id);
        Task<bool> Exists(int id);
    }
}
