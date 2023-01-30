using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Domain.PrimaryEntities;

namespace ShoppingCart.Persistence.Repositories
{
    public class ProductInfoRepository : GenericRepository<ProductInfo>, IProductInfoRepository
    {
        private readonly ShoppingCartDbContext _dbContext;

        public ProductInfoRepository(ShoppingCartDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
