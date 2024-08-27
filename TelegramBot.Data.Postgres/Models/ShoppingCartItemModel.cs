namespace TelegramBot.Data.Postgres.Models;

public class ShoppingCartItemModel
{
    public Guid Id { get; set; }

    public int Amount { get; set; }

    public ProductModel Product { get; set; }

    public ShoppingCartModel ShoppingCart { get; set; }

    public string ShoppingCartId { get; set; }
}

