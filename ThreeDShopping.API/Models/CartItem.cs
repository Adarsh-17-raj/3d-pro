using System.ComponentModel.DataAnnotations;

namespace ThreeDShopping.API.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        // Navigation property to fetch product details (Price, Name, 3D Model URL) automatically
        public Product? Product { get; set; }
    }
}