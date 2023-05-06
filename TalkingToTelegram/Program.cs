using System.Runtime.CompilerServices;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;


namespace TalkingToTelegram
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var botClient = new TelegramBotClient("6********6:Aqwerty*************sdkn35r");
                var chatId = "@te************h";
                var message = "Hello, world!";
                await botClient.SendTextMessageAsync(chatId, message, ParseMode.Markdown);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}