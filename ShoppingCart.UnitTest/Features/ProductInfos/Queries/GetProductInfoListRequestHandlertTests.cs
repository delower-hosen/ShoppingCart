using AutoMapper;
using Moq;
using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Application.DTOs.ProductInfo;
using ShoppingCart.Application.Features.ProductInfos.Handlers.Queries;
using ShoppingCart.Application.Features.ProductInfos.Requests.Queries;
using ShoppingCart.Application.Profiles;
using ShoppingCart.Application.UnitTest.Mocks;
using Shouldly;

namespace ShoppingCart.Application.UnitTest.Features.ProductInfos.Queries
{
    public class GetProductInfoListRequestHandlertTests
    {
        private readonly Mock<IProductInfoRepository> _mockRepo;
        private readonly IMapper _mapper;

        public GetProductInfoListRequestHandlertTests()
        {
            _mockRepo = MockProductInfoRepository.GetMockProductInfoRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetProductInfoListTest()
        {
            var handler = new GetProductInfoListRequestHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetProductInfoListRequest(), CancellationToken.None);

            result.ShouldBeOfType<List<ProductInfoListDto>>();
            result.Count.ShouldBe(2);
        }
    }
}
