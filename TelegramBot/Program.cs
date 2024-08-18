using Microsoft.Extensions.Options;
using Telegram.Bot;
using TelegramBot.Options;
using TelegramBot.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<TelegramBotServiceMain>();

builder.Services.AddTransient<ITelegramBotClient, TelegramBotClient>(serviceProvider =>
{
    var token = serviceProvider.GetRequiredService<IOptions<TelegramOptions>>().Value.Token;
    return new(token);
});

builder.Services.Configure<TelegramOptions>(builder.Configuration.GetSection(TelegramOptions.Telegram));

var app = builder.Build();
app.Run();