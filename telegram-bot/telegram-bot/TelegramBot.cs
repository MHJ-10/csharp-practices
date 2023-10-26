using Telegram.Bot;
using Telegram.Bot.Types;
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
            Console.WriteLine("start receiving...");
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
                string text;

                text = responseText switch
                {
                    "hello" => "Hi",
                    "goodbye" => "Have a good day.",
                    "who are you?" => "I am a bot.",
                    "how are you" => "I am so-so",
                    "what time is it?" => (DateTime.Now.ToString("HH:mm")),
                    "what date is today?" => DateTime.Today.ToString("yyyy/MM/dd"),
                    "i am hungry" => "Unfortunately, I can't do anything for you.",
                    _ => "Default message to answer this text is not provided.",
                };


                if (update.Message.Type == Enums.MessageType.Text)
                    await client.SendTextMessageAsync(chatId, text);
                else
                    await client.SendTextMessageAsync(
                        chatId,
                        text: $"hey @{username}, i just can answer to text.",
                        replyToMessageId: message.MessageId);
            }


        }
        public Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token) =>
            throw new Exception(exception.Message);


    }
}