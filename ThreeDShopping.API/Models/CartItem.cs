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

        public Product? Product { get; set; }
    }
}