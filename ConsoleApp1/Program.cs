using LanguageBot;
using System;
using Telegram.Bot.Args;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = Bot.Get();
            client.Timeout = TimeSpan.FromSeconds(10);
            var info = client.GetMeAsync().Result;
            Console.WriteLine(info.Id + " " + info.FirstName);
            client.OnMessage += Bot_OnMessage;
            client.StartReceiving();
        }

        private static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            TextMessageHandler.OnMessageAsync(e.Message);
        }
    }
}
