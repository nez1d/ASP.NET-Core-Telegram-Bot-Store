using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class OrderModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public int Amount { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public decimal OrderTotal { get; set; }
    [Required]
    public DateTime OrderPlaced { get; set; }
    [Required]
    public string UserId { get; set; }
    [Required]
    public UserModel User { get; set; }
    [Required]
    public ProductModel ProductModel { get; set; }
}