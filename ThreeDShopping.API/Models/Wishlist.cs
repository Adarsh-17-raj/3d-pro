using System.ComponentModel.DataAnnotations;

namespace ThreeDShopping.API.Models
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        // Navigation property to return product details to the wishlist UI
        public Product? Product { get; set; }
    }
}