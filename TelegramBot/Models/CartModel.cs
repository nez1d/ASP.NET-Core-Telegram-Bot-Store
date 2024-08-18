using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Models
{
    public class CartModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Count { get; set; } = 0;
        [Required]
        public decimal FullPrice { get; set; } = 0;
        [Required]
        public UserModel User { get; set; }
        [Required]
        public ProductModel Prodcuts { get; set; }
        // TODO: Доделать подсчет стоимости всех товаров
        public decimal GetAllProducts()
        {
            return 0;
        }
    }
}
