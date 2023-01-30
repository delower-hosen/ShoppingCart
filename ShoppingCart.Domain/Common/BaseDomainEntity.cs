using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Domain.Common
{
    public abstract class BaseDomainEntity // abstract, as this can be only inherited, but can't be instantiated
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
