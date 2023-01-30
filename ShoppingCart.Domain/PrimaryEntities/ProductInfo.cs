using ShoppingCart.Domain.Common;

namespace ShoppingCart.Domain.PrimaryEntities
{
    public class ProductInfo : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsStockAvailable { get; set; }
        public int Price { get; set; }
    }
}
