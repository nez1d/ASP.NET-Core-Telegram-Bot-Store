using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<ProductModel>
{
    public void Configure(EntityTypeBuilder<ProductModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.
            HasOne(c => c.Category)
            .WithMany(p => p.Products);
    }
}

