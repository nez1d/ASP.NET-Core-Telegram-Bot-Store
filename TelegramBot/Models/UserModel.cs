using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int User { get; set; }
        [Required]
        public int Balance { get; set; }
    }
}
