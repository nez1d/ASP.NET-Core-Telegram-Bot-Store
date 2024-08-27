using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.
            HasOne(u => u.UserDetail)
            .WithOne(u => u.User);
    }
}