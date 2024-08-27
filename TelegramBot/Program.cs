using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using TelegramBot.Data.Postgres;
using TelegramBot.Options;
using TelegramBot.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<TelegramBotServiceMain>();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddTransient<ITelegramBotClient, TelegramBotClient>(serviceProvider =>
{
    var token = serviceProvider.GetRequiredService<IOptions<TelegramOptions>>().Value.Token;
    return new(token);
});

builder.Services.AddDbContext<ApplicatoinDbContext>(
    options =>
    {
        options.UseNpgsql(connection);
    });

builder.Services.Configure<TelegramOptions>(builder.Configuration.GetSection(TelegramOptions.Telegram));

var app = builder.Build();
app.Run();