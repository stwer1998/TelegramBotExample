using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace LanguageBot
{
    public class StatisticCommand : Command
    {
        public override string PreviousCommand => "/ChosseLang";

        public override string CommandName => "/Static";


        public override bool CanUse(long chatId)
        {
          return Bot.Users.FirstOrDefault(x => x.Id == chatId).PreviousCommand == PreviousCommand;
        }
        public override Task ExecuteAsync(Message message, TelegramBotClient client)
        {
            //db statisticget and send client; 
            client.SendTextMessageAsync(chatId: message.Chat.Id, text: "Db int");           
            return Task.CompletedTask;
        }
    }
}
