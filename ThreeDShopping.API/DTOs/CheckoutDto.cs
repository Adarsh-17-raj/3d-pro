using System.ComponentModel.DataAnnotations;

namespace ThreeDShopping.API.DTOs
{
    public class CheckoutDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [CreditCard]
        public string CardNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "CVV must be exactly 3 digits.")]
        public string CVV { get; set; } = string.Empty;

        [Required]
        public decimal TotalAmount { get; set; }
    }
}