namespace TelegramBot.Data.Postgres.Models;

public class ProductModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string Brend { get; set; }

    public CategoryModel Category { get; set; }

    public string CategoryName { get; set; }
}

