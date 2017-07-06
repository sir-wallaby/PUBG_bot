using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace PUBG_bot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task testOutCommand(string repeat)
        {
            await Context.Channel.SendMessageAsync(repeat);
        }
    }
}
