using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres.Configurations;

public class ShoppingCartItemConfiguration : IEntityTypeConfiguration<ShoppingCartItemModel>
{
    public void Configure(EntityTypeBuilder<ShoppingCartItemModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.
            HasOne(p => p.Product);
    }
}

