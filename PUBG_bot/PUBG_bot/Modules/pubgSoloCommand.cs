using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using PUBG_bot.Properties;
using PUBGSharp;
using PUBGSharp.Data;
using PUBGSharp.Exceptions;
using PUBGSharp.Helpers;

namespace PUBG_bot.Modules
{
    public class pubgSoloCommand : ModuleBase<SocketCommandContext>
    {

        [Command("so")]
        [Summary("Solo statistics for PUBG based from PUBGOnline")]
        public async Task soloAllRegions([Remainder] string user)
        {
            
            var username = user;
            string apiKey = Settings.Default.apiKey;
            //create the statsClient with api key
            var statsClient = new PUBGStatsClient(apiKey);
            //wrapper to call the api
            var stats = await statsClient.GetPlayerStatsAsync(username);

            try
            {
                var SquadRank = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.Rating).Rank;

                var KDR = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.KDR).Value;

                var kills = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.Kills).Value;

                var wins = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.Wins).Value;

                var win_percentage = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.WinPercentage).Value;

                var roundsPlayed = stats.Stats.Find(x =>
                    x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                        x.Stat == Stats.RoundsPlayed).Value;

                var KPG = stats.Stats.Find(x =>
                   x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                       x.Stat == Stats.KillsPerGame).Value;

                var longestkill = stats.Stats.Find(x =>
                  x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                      x.Stat == Stats.LongestKill).Value;

                var KO = stats.Stats.Find(x =>
                  x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                      x.Stat == Stats.Knockouts).Value;

                var rating = stats.Stats.Find(x =>
                  x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                      x.Stat == Stats.Rating).Value;

                double knockoutsPerGame = Math.Round((double.Parse(KO) / double.Parse(roundsPlayed)), 3);

                var assists = stats.Stats.Find(x =>
                  x.Mode == Mode.Solo && x.Region == Region.AGG && x.Season == Seasons.EASeason3).Stats.Find(x =>
                      x.Stat == Stats.Assists).Value;

                await Context.Channel.SendMessageAsync("\n```Rank: " + SquadRank.ToString() + "\n" +
                                                        "Rating: " + rating.ToString() + "\n" + "\n" +

                                                        "KDR: " + KDR.ToString() + "\n" +
                                                        "Kills: " + kills.ToString() + "\n" +
                                                        "Kills/Game: " + KPG.ToString() + "\n" +
                                                        "Assits: " + assists.ToString() + "\n" +                                                        
                                                        "Longest Kill: " + longestkill.ToString() + " meters \n" + "\n" +

                                                        "Wins: " + wins.ToString() + "\n" +
                                                        "Win Percentage: " + win_percentage + "\n" +
                                                        "Games Played: " + roundsPlayed + "\n" + "```");
                

            }

            catch (PUBGSharpException ex)
            {
                await ReplyAsync("Could not retrieve stats for " + username + " error: " + ex.Message);
                throw;
            }

            catch (ArgumentNullException excep)
            {
                await ReplyAsync("Could not retrieve stats for " + username + " error: " + excep.Message);
                throw;
            }
        }

    }
}
