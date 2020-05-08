using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace LanguageBot
{
    public class StartCommand : Command
    {
        public override string PreviousCommand => "";

        public override string CommandName => "/start";

        public override bool CanUse(long chatId)
        {
            return true;
        }

        

        public override Task ExecuteAsync(Message message, TelegramBotClient client)
        {
            Bot.Users.Add(new User() {Id=message.Chat.Id,PreviousCommand="/start" });
            client.SendTextMessageAsync(message.Chat.Id,"ChooseLang");
            return Task.CompletedTask;
        }
    }
}
