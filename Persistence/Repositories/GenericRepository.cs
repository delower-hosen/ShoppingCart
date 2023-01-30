using Microsoft.EntityFrameworkCore;
using ShoppingCart.Application.Contracts.Persistence;

namespace ShoppingCart.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ShoppingCartDbContext _dbContext;

        public GenericRepository(ShoppingCartDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
