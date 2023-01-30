using AutoMapper;
using MediatR;
using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Application.DTOs.ProductInfo;
using ShoppingCart.Application.Features.ProductInfos.Requests.Queries;

namespace ShoppingCart.Application.Features.ProductInfos.Handlers.Queries
{
    public class GetProductInfoListRequestHandler : IRequestHandler<GetProductInfoListRequest, List<ProductInfoListDto>>
    {
        private readonly IProductInfoRepository _productInfoRepository;
        private readonly IMapper _mapper;

        public GetProductInfoListRequestHandler(IProductInfoRepository productInfoRepository, IMapper mapper)
        {
            _productInfoRepository = productInfoRepository;
            _mapper = mapper;
        }
        public async Task<List<ProductInfoListDto>> Handle(GetProductInfoListRequest request, CancellationToken cancellationToken)
        {
            var productInfos = await _productInfoRepository.GetAll();
            return _mapper.Map<List<ProductInfoListDto>>(productInfos);
        }
    }
}
