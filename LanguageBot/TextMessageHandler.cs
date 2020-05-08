using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telegram.Bot.Types;

namespace LanguageBot
{
    public static class TextMessageHandler
    {
        public static async void OnMessageAsync(Message message) 
        {
            //statistic  vzyal static canuse 
            if (Bot.Commands.FirstOrDefault(x => x.CommandName == message.Text).CanUse(message.Chat.Id))
            {
                var cmd = Bot.Commands.FirstOrDefault(x => x.CommandName == message.Text);
                cmd.ExecuteAsync(message, Bot.Get());
            }
            else 
            {
                //some todo
            }
        }
    }
}
