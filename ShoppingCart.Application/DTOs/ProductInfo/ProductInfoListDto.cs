using ShoppingCart.Application.DTOs.Common;

namespace ShoppingCart.Application.DTOs.ProductInfo
{
    public class ProductInfoListDto : BaseDTO
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public bool IsStockAvailable { get; set; }
        public int Price { get; set; }
    }
}
