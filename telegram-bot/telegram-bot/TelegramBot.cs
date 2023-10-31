using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Enums = Telegram.Bot.Types.Enums;

namespace telegram_bot
{
    public class TelegramBot
    {
        private string Token { get; set; }
        private TelegramBotClient telegramBot;

        public TelegramBot(string token)
        {
            this.Token = token;
            this.telegramBot = new TelegramBotClient(token);
        }

        public void StartBot()
        {
            this.telegramBot.StartReceiving(UpdateHandler, ErrorHandler);
            Console.WriteLine("Start receiving...");
            Console.ReadKey();
        }

        public async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
        {
            Message message;
            if (update.Message != null)
            {
                message = update.Message;
                var chatId = message.Chat.Id;
                var username = message.Chat.Username;
                var responseText = message.Text;
                string text = "Select one of the dishes to see its cooking instructions.";

                if (update.Message.Type == Enums.MessageType.Text)
                {
                    var foodsListApi = new FoodsListApi(responseText);
                    var foods = await foodsListApi.GetFoodsList();

                    if (foods.Count > 0)
                    {
                        var foodNameButtons = new List<InlineKeyboardButton[]>();

                        foreach (var food in foods)
                        {
                            var foodNameButton = InlineKeyboardButton.WithCallbackData(food.Title, food.Id.ToString());
                            foodNameButtons.Add(new[] { foodNameButton });
                        }

                        var keyboard = new InlineKeyboardMarkup(foodNameButtons);

                        await client.SendTextMessageAsync(chatId, text, replyMarkup: keyboard);
                    }
                    else
                    {
                        text = "No food found.";
                        await client.SendTextMessageAsync(chatId, text);
                    }

                }
                else
                {
                    await client.SendTextMessageAsync
                        (
                         chatId,
                         text: $"@{username}, I can only reply to texts."
                        );
                }

            }
            else if (update.CallbackQuery != null)
            {
                var callbackQuery = update.CallbackQuery;
                string foodId = callbackQuery.Data;
                var chatId = callbackQuery.Message.Chat.Id;

                var foodInstructionApi = new FoodInstructionApi(foodId);
                var foodInstruction = await foodInstructionApi.GetFoodDetail();

                string foodInstructionItem = "";

                if (foodInstruction.Count > 0)
                {

                    foreach (var item in foodInstruction)
                    {
                        foreach (var step in item.Steps)
                        {
                            foodInstructionItem += $"{step.Number} - {step.Step}\n";
                        }
                    }
                }
                else
                {
                    foodInstructionItem = "No recipes were found for selected food.";
                }

                await client.SendTextMessageAsync(chatId, foodInstructionItem);
            }
        }

        public Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            Console.WriteLine("An error occurred: " + exception.Message);
            throw new Exception(exception.Message);
        }
    }
}