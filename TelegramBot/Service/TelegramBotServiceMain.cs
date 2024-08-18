using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using TelegramBot.Options;

namespace TelegramBot.Service
{
    public class TelegramBotServiceMain : BackgroundService
    {
        private readonly ILogger<TelegramBotServiceMain> _logger;
        private readonly ITelegramBotClient _client;
        private readonly TelegramOptions _options;
        private readonly TelegramBotServiceOptions _telegramBotServiceOptions = new TelegramBotServiceOptions();

        public TelegramBotServiceMain(ILogger<TelegramBotServiceMain> logger,
            ITelegramBotClient client,
            IOptions<TelegramOptions> options)
        {
            _logger = logger;
            _client = client;
            _options = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var botClient = new TelegramBotClient("7316098393:AAH1cCx2pU8bDS69yq-5QRDibNHFXpOAO7o");

            ReceiverOptions receiverOptions = new()
            {
                AllowedUpdates = []
            };

            while (!stoppingToken.IsCancellationRequested)
            {
                await botClient.ReceiveAsync(
                    updateHandler: OnUpdate,
                    pollingErrorHandler: OnError,
                    receiverOptions: receiverOptions,
                    cancellationToken: stoppingToken);
            }
        }

        async Task OnUpdate(ITelegramBotClient botClient,
            Update update,
            CancellationToken cancellationToken)
        {
            if (update.Message is not { } message)
                return;
            if (message.Text is not { } messageText)
                return;

            var chatId = message.Chat.Id;

            switch (message.Text)
            {
                case "/start":
                    await _telegramBotServiceOptions
                        .HandleStart(botClient, cancellationToken, message);
                    break;
                case "/help":
                    await _telegramBotServiceOptions
                        .HandleHelp(botClient, cancellationToken, message);
                    break;
                case "/buy":
                    await _telegramBotServiceOptions
                        .HandleBrend(botClient, cancellationToken, message);
                    break;
                case "/info":
                    await botClient.SendTextMessageAsync(chatId, "Info: ");
                    break;
                default:
                    break;
            }
        }

        Task OnError(ITelegramBotClient telegramBotClient,
            Exception exception,
            CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $""
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }

        

    }
}

