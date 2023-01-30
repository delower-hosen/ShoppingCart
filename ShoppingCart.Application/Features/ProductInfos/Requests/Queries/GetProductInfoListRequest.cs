using MediatR;
using ShoppingCart.Application.DTOs.ProductInfo;

namespace ShoppingCart.Application.Features.ProductInfos.Requests.Queries
{
    public class GetProductInfoListRequest : IRequest<List<ProductInfoListDto>>
    {
    }
}
