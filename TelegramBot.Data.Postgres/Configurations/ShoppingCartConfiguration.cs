using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres.Configurations;

public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCartModel>
{
    public void Configure(EntityTypeBuilder<ShoppingCartModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.
            HasMany(s => s.ShoppingCartItems)
            .WithOne(c => c.ShoppingCart)
            .HasForeignKey(c => c.ShoppingCartId);
    }
}