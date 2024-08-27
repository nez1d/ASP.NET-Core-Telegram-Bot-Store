using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<OrderModel>
{
    public void Configure(EntityTypeBuilder<OrderModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.
            HasOne(u => u.User);

        builder.
            HasOne(p => p.ProductModel);
    }
}