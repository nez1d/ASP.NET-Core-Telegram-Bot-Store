using System.ComponentModel.DataAnnotations;

namespace TelegramBot.Data.Postgres.Models;

public class ShoppingCartModel
{
    [Key]
    [Required]
    public string Id { get; set; }
    [Required]
    public IEnumerable<ShoppingCartItemModel> ShoppingCartItems { get; set; }

    public static ShoppingCartModel GetCart(IServiceProvider services)
    {
        throw new NotImplementedException();
    }

    public bool AddToCart(ProductModel food, int amount)
    {
        throw new NotImplementedException();
    }

    public int RemoveFromCart(ProductModel food)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ShoppingCartItemModel> GetShoppingCartItems()
    {
        throw new NotImplementedException();
    }

    public void ClearCart()
    {
        throw new NotImplementedException();
    }

    public decimal GetShoppingCartTotal()
    {
        throw new NotImplementedException();

    }
}