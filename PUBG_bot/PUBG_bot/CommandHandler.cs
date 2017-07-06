using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord.Commands;
using System.Reflection;

namespace PUBG_bot
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;
        private char prefix = '!';

        public async Task InitializeAsync(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            await _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg is null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;
            if(msg.HasCharPrefix(prefix, ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos);

                if (!result.IsSuccess)
                {
                    await context.Channel.SendMessageAsync(result.ErrorReason);
                }

            }
        }

    }
}
