using Discord;
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
            await ReplyAsync("Starless is the cutest and sweetest stag ever <3");
        }
        [Command("cocaine")]
        public async Task CocaineCommand()
        {
            await ReplyAsync("Praise the Omnissiah!!!");
        }
        [Command("skye")]
        public async Task SkyeCommand() {
            Emote skyeHug = Emote.Parse("<:skyeStarlessHug:813449589897297920>");
            await ReplyAsync(@$"Skye is the cutest woofie >w< {skyeHug}");
        }
        [Command("ping")]
        public async Task PingCommand()
        {
            await ReplyAsync($"Pong {Context.Message.Author.Username} <@{Context.Message.Author.Id}>");
        }
    }
}
