using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Models
{
    public class ProductModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Count { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Price { get; set; }
        [Required]
        public string ImageUrl { get; set; }
    }
}
