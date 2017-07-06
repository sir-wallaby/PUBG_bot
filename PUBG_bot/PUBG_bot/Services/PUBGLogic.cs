using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUBGSharp;
using PUBG_bot.Properties;
using PUBGSharp.Data;
using PUBGSharp.Helpers;

namespace PUBG_bot.Services
{
    public class PUBGLogic
    {
        //TODO: work on making this a service
        //public async Task connectToApi(string userID)
        //{

        //    var pubgUsername = userID;
        //    string apiKey = PUBG_bot.Properties.Settings.Default.apiKey;
        //    //create a stats client with proper api key
        //    var statsClient = new PUBGStatsClient(apiKey);
        //    //use wrapper to call out the api
        //    var stats = await statsClient.GetPlayerStatsAsync(pubgUsername);



        //    try
        //    {
        //        var duoRank = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.Rating).Rank;

        //        var KDR = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.KDR).Value;

        //        var kills = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.Kills).Value;

        //        var wins = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.Wins).Value;

        //        var win_percentage = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.WinPercentage).Value;

        //        var roundsPlayed = stats.Stats.Find(x =>
        //            x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //                x.Stat == Stats.RoundsPlayed).Value;

        //        var KPG = stats.Stats.Find(x =>
        //           x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //               x.Stat == Stats.KillsPerGame).Value;

        //        var longestkill = stats.Stats.Find(x =>
        //          x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //              x.Stat == Stats.LongestKill).Value;

        //        var KO = stats.Stats.Find(x =>
        //          x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //              x.Stat == Stats.Knockouts).Value;

        //        var rating = stats.Stats.Find(x =>
        //          x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //              x.Stat == Stats.Rating).Value;

        //        var assists = stats.Stats.Find(x =>
        //         x.Mode == Mode.Duo && x.Region == Region.NA && x.Season == Season.EASeason2).Stats.Find(x =>
        //             x.Stat == Stats.Assists).Value;

        //        double knockoutsPerGame = Math.Round((double.Parse(KO) / double.Parse(roundsPlayed)), 3);
        //        //store the output
        //        string results = "";

        //        results = ("\n```Rank: " + duoRank.ToString() + "\n" +
        //                                                      "Rating: " + rating.ToString() + "\n" + "\n" +

        //                                                      "KDR: " + KDR.ToString() + "\n" +
        //                                                      "Kills: " + kills.ToString() + "\n" +
        //                                                      "Kills/Game: " + KPG.ToString() + "\n" +
        //                                                      "Assists: " + assists.ToString() + "\n" +
        //                                                      "Knockouts: " + KO.ToString() + "\n" +
        //                                                      "Knockouts/Game: " + knockoutsPerGame.ToString() + "\n" +
        //                                                      "Longest Kill: " + longestkill.ToString() + " meters \n" + "\n" +

        //                                                      "Wins: " + wins.ToString() + "\n" +
        //                                                      "Win Percentage: " + win_percentage + "\n" +
        //                                                      "Games Played: " + roundsPlayed + "\n" + "```");

        //        //await e.Channel.SendMessage("Stats last updated at: " + stats.LastUpdated);

        //    }

        //    catch (PUBGSharp.Exceptions.PUBGSharpException)
        //    {

        //        throw;
        //        //await e.Channel.SendMessage("Could not retrieve stats for " + pubgUsername_PC + " error: " + ex.Message);
        //    }

        //    catch (ArgumentNullException excep)
        //    {
        //        string error = "";
        //        error = ("Could not retrieve stats for " + pubgUsername + " error: " + excep.Message);
        //    }
        //}

            
        

    }
}





