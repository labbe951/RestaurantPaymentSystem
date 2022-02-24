namespace RestaurantPaymentSystem.Data.Repositories
{
    public interface IAsyncRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int ID);
        Task<IReadOnlyList<TEntity>> ListAllAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
        Task<IReadOnlyList<TEntity>> AddRangeAsync(List<TEntity> entity);


    }
}
