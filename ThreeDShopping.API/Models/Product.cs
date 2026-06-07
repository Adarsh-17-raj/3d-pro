using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThreeDShopping.API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int StockQuantity { get; set; } // Handles Product Availability [cite: 4]

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        [cite_start]// 3D Visualizer Fields 
        [Required]
        public string ThreeDModelUrl { get; set; } = string.Empty; // Path to .gltf/.glb asset file

        public string? ThumbnailUrl { get; set; } // For fast-loading image previews
    }
}