using Microsoft.EntityFrameworkCore;

namespace RestaurantPaymentSystem.Data.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly RestaurantContext _RestaurantContext;
        public BaseRepository(RestaurantContext myDbContext)
        {
            _RestaurantContext = myDbContext;
        }

        //Här körs anroppen mot databasen

        //Väldigt viktigt att i BaseRepository ska endast finnas metoder som flera klasser ska använda sig utav
        //Annars ska man skriva det i den specifika repositorien. Tex ModelRepository

        public async Task<T> GetByIdAsync(int id)
        {
            return await _RestaurantContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _RestaurantContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> AddRangeAsync(List<T> entity)
        {
            await _RestaurantContext.Set<T>().AddRangeAsync(entity);
            await _RestaurantContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _RestaurantContext.Set<T>().AddAsync(entity);
            await _RestaurantContext.SaveChangesAsync();

            return entity;
        }


        public async Task DeleteAsync(T entity)
        {
            _RestaurantContext.Set<T>().Remove(entity);
            await _RestaurantContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _RestaurantContext.Update(entity);
            await _RestaurantContext.SaveChangesAsync();

        }




    }
}
