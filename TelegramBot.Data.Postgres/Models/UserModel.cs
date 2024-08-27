using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class UserModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Login { get; set; }
    [Required]
    [StringLength(100)]
    public string Email { get; set; }
    [Required]
    [StringLength(100)]
    public string Password { get; set; }
    [Required]
    public UserDetailModel UserDetail { get; set; }
}