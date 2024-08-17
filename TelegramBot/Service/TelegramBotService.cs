using Microsoft.Extensions.Options;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.Options;

namespace TelegramBot.Service
{
    public class TelegramBotService : BackgroundService
    {
        private readonly ILogger<TelegramBotService> _logger;
        private readonly ITelegramBotClient _client;
        private readonly TelegramOptions _options;

        public TelegramBotService(ILogger<TelegramBotService> logger,
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
                    await botClient.SendTextMessageAsync(chatId, "Hello I'm test bot!");
                    break;
                case "/help":
                    await botClient.SendTextMessageAsync(chatId, "Help");
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

        private async Task MessageTestHandler(Message message, CancellationToken cancellationToken)
        {
            /*InlineKeyboardMarkup inlineKeyboard = new(
            [
                [InlineKeyboardButton.WithCallbackData("Yes", "lessons-info")],
                [InlineKeyboardButton.WithCallbackData("No", "lessons-application")],
            ]);*/
        }

        private async Task SendMessage()
        {

        }
    }
}

