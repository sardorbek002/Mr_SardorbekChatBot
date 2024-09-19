using Telegram.Bot;

namespace Mr_SardorbekChatBot
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            TelegramBotClient botClient = new("6845410120:AAHh8UY7sMchqxi-fPTycnCB0uzt-15y1j0");
           // string botToken = "6845410120:AAHh8UY7sMchqxi-fPTycnCB0uzt-15y1j0";
            long chatID = 6009684277;
            Console.WriteLine("Xabar Kiriting :");
            string message=Console.ReadLine();
             var response=await   botClient.SendTextMessageAsync(chatID, message);
            await Console.Out.WriteLineAsync(response.MessageId.ToString());
            botClient.StartReceiving(new MessageHandler());
            Console.ReadLine();
        }
    }
}