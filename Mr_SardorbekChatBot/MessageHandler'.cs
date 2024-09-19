using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace Mr_SardorbekChatBot
{
    public class MessageHandler : IUpdateHandler
    {
        public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message.Text.Contains("Salom"))
            {
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Salom");
            }
            else if(update.Message.Text.Contains("Qalesiz"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Yxshi raxmat ozizchi");


            else if (update.Message.Text.Contains("Yaxshiman raxmat"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Oqishlar yaxshimi");
            else if (update.Message.Text.Contains("Raxmat boladi Nima gaplar"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Bizda tinchlik oqib yuribmizu");

            else if (update.Message.Text.Contains("Sevganing bormi"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Ha bor");
          

            else if (update.Message.Text.Contains("Hello"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Salom");
            else if (update.Message.Text.Contains("How are you"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Qalaysiz");
            else if (update.Message.Text.Contains("Thank you"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Rahmat");
            else if (update.Message.Text.Contains("Goodbye"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Xayr");
            else if (update.Message.Text.Contains("Please"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Iltimos");
            else if (update.Message.Text.Contains("Sorry"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Uzr");
            else if (update.Message.Text.Contains("Yes"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Ha");
            else if (update.Message.Text.Contains("No"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Yo'q");
            else if (update.Message.Text.Contains("Help"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Yordam");
            else if (update.Message.Text.Contains("Nice to meet you"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "Tanishganimdan xursandman");
            else if (update.Message.Text.Contains("Salom"))
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "salom");
            else
                await botClient.SendTextMessageAsync(update.Message.Chat.Id, "I don't understand");


            Console.WriteLine(update.Message.Text);
        }
    }
}
