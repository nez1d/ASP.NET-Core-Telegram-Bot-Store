using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class ProductModel
{
    [Key]
    [Required]
    public Guid Id { get; set; }
    [Required]
    [StringLength(150)]
    public string Name { get; set; }
    [StringLength(2000)]
    public string Description { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    [StringLength(50)]
    public string BrandName { get; set; }
    [Required]
    public CategoryModel? Category { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
}