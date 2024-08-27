using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class CategoryModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public IEnumerable<ProductModel> Products { get; set; } = [];
}