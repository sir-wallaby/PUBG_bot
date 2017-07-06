using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBG_bot.Properties;
using Discord.WebSocket;

namespace PUBG_bot
{
    public class Program
    {
        public static void Main(string[] args)
                    => new Program().MainAsync().GetAwaiter().GetResult();

        private CommandHandler _handler;
        public async Task MainAsync()
        {
            
            var client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Info
            });

            client.Log += Log;

            string token = PUBG_bot.Properties.Settings.Default.botToken;
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            //TODO: add the Dependency map here


            //TODO: add the map into the command handler
            _handler = new CommandHandler();
            await _handler.InitializeAsync(client);

            //block this task until the program is closed
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        
        
    }
}
