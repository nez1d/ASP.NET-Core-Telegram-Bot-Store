using Microsoft.EntityFrameworkCore;
using TelegramBot.Data.Postgres.Models;

namespace TelegramBot.Data.Postgres;

public class ApplicatoinDbContext : DbContext
{
    public ApplicatoinDbContext(DbContextOptions<ApplicatoinDbContext> options) : base(options)
    { 
    } 

    public DbSet<CategoryModel> Category { get; set; }
    public DbSet<UserModel> User { get; set; }
    public DbSet<ProductModel> Products { get; set; }
}

