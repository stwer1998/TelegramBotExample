using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace LanguageBot
{
    public static class Bot
    {
        private static TelegramBotClient client;

        public static List<User> Users = new List<User>();

        public static List<Command> Commands;

        public static TelegramBotClient Get()
        {
            if (client != null)
            {
                return client;
            }
            Commands = new List<Command>() {
                new StartCommand(),
                new ChooseLang(),
                new StartCommand()
            };           
            
            return client= new TelegramBotClient();
        }
    }
}
