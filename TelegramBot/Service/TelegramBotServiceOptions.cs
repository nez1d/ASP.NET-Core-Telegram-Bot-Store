using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace TelegramBot.Service
{
    public class TelegramBotServiceOptions
    {
        public async Task HandleStart(ITelegramBotClient botClient,
            CancellationToken cancellationToken,
            Message message)
        {
            InlineKeyboardMarkup inlineKeyboard = new(
            [
                [InlineKeyboardButton.WithCallbackData("Выбрать товар", "products-info")],
                [InlineKeyboardButton.WithCallbackData("Корзина", "cart-info")],
            ]);

            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Выбери опцию: ",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }

        public async Task HandleHelp(ITelegramBotClient botClient,
            CancellationToken cancellationToken,
            Message message)
        {
            InlineKeyboardMarkup inlineKeyboard = new(
            [
                [InlineKeyboardButton.WithCallbackData("Проблема с оплатой товара.", "products-info")],
                [InlineKeyboardButton.WithCallbackData("Задержка доставки.", "products-info")],
                [InlineKeyboardButton.WithCallbackData("Не могу войти в свой аккаунт.", "products-info")],
                [InlineKeyboardButton.WithCallbackData("Интересующего меня товара нету в наличии.", "products-info")],
                [InlineKeyboardButton.WithCallbackData("Связать меня с поддержкой.", "lessons-application")],
            ]);

            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Нужна помощь? Пожалуйста, выберите проблему из списка: ",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }

        public async Task HandleBrend(ITelegramBotClient botClient,
            CancellationToken cancellationToken,
            Message message)
        {
            InlineKeyboardMarkup inlineKeyboard = new(
                [
                    [
                        InlineKeyboardButton.WithCallbackData("Nike.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Adidas.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("New Balance.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Arc'teryx.", "products-info"),
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Stone Island.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Acics.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("y2k.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Big Boy.", "products-info"),
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Puma.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Corteiz.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Guess.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Stussy.", "products-info"),
                    ],
                    [
                        InlineKeyboardButton.WithCallbackData("Yeezy Gap.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Carhartt.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Vans.", "products-info"),
                        InlineKeyboardButton.WithCallbackData("Not Brend.", "products-info"),
                    ]
                ]
            );

            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Пожалуйста, выберите интересующий вас бренд: ",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }
    }
}
