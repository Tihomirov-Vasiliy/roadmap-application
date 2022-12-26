namespace Application.Common
{
    public interface ICrudRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(int id);
    }
}
