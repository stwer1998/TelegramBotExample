using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace LanguageBot
{
    public class ChooseLang : Command
    {
        public override string PreviousCommand => "/start";

        public override string CommandName => "/chooseLang";

        public override bool CanUse(long chatId)
        {
            return Bot.Users.FirstOrDefault(x => x.Id == chatId).PreviousCommand == "/start";
        }

        public override Task ExecuteAsync(Message message, TelegramBotClient client)
        {
            throw new NotImplementedException();
        }
    }
}
