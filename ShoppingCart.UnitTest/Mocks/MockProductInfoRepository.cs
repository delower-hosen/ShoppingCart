using Moq;
using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Domain.PrimaryEntities;

namespace ShoppingCart.Application.UnitTest.Mocks
{
    public class MockProductInfoRepository
    {
        public static Mock<IProductInfoRepository> GetMockProductInfoRepository()
        {
            var productInfos = new List<ProductInfo>
            {
                new ProductInfo
                {
                    Id = 1,
                    Name = "Test 1",
                    Description = "Test description 1",
                    Category = "Phone",
                    IsStockAvailable = true,
                    Price = 10
                },
                new ProductInfo
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Test description 2",
                    Category = "Phone",
                    IsStockAvailable = true,
                    Price = 10
                }
            };

            var mockRepo = new Mock<IProductInfoRepository>();

            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(productInfos);

            return mockRepo;
        }
    }
}
