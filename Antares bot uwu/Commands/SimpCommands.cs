using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antares_bot_uwu
{
    public class SimpCommands : ModuleBase<SocketCommandContext>
    {
        [Command("starless")]
        public async Task StarlessCommand() {
            await ReplyAsync("Starless is the cutest stag ever <3");
        }
        [Command("cocaine")]
        public async Task CocaineCommand()
        {
            await ReplyAsync("Praise the Omnissiah!!!");
        }
    }
}
