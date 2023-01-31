using AutoMapper;
using MediatR;
using ShoppingCart.Application.Contracts.Logging;
using ShoppingCart.Application.Contracts.Persistence;
using ShoppingCart.Application.DTOs.ProductInfo;
using ShoppingCart.Application.Features.ProductInfos.Requests.Queries;

namespace ShoppingCart.Application.Features.ProductInfos.Handlers.Queries
{
    public class GetProductInfoListRequestHandler : IRequestHandler<GetProductInfoListRequest, List<ProductInfoListDto>>
    {
        private readonly IProductInfoRepository _productInfoRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetProductInfoListRequestHandler> _logger;

        public GetProductInfoListRequestHandler(IProductInfoRepository productInfoRepository,
            IMapper mapper,
            IAppLogger<GetProductInfoListRequestHandler> logger)
        {
            _productInfoRepository = productInfoRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<ProductInfoListDto>> Handle(GetProductInfoListRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("logging started testing");
            var productInfos = await _productInfoRepository.GetAll();
            _logger.LogInformation("product infos were retrieved succesfully.");
            return _mapper.Map<List<ProductInfoListDto>>(productInfos);
        }
    }
}
