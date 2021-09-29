﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MingweiSamuel.Camille.Enums;

namespace MingweiSamuel.Camille.Test
{
    [TestClass]
    public class ReadmeExampleTest : ApiTest
    {
        [TestMethod]
        public void SummonerChampionMastery()
        {
            // Use existing instance for test.
            var riotApi = Api;

            // Get summoners by name synchronously. (using async is faster).
            var summoners = new[]
            {
                riotApi.SummonerV4.GetBySummonerName(Region.NA, "jAnna kendrick"),
                riotApi.SummonerV4.GetBySummonerName(Region.NA, "lug nuts k")
            };

            foreach (var summoner in summoners)
            {
                Console.WriteLine($"{summoner.Name}'s Top 10 Champs:");

                var masteries =
                    riotApi.ChampionMasteryV4.GetAllChampionMasteries(Region.NA, summoner.Id);

                for (var i = 0; i < 10; i++)
                {
                    var mastery = masteries[i];
                    // Get champion for this mastery.
                    var champ = (Champion) mastery.ChampionId;
                    // print i, champ id, champ mastery points, and champ level
                    Console.WriteLine("{0,3}) {1,-16} {2,10:N0} ({3})", i + 1, champ.Name(),
                        mastery.ChampionPoints, mastery.ChampionLevel);
                }
                Console.WriteLine();
            }
        }

        //[TestMethod]
        //public async Task SummonerMatchHistoryAsync()
        //{
        //    // Use existing instance for test.
        //    var riotApi = Api;

        //    var summonerNameQuery = "lugnutsk";

        //    // Get summoners data (blocking).
        //    var summonerData = await riotApi.SummonerV4.GetBySummonerNameAsync(Region.NA, summonerNameQuery);
        //    if (null == summonerData)
        //    {
        //        // If a summoner is not found, the response will be null.
        //        Console.WriteLine($"Summoner '{summonerNameQuery}' not found.");
        //        return;
        //    }

        //    Console.WriteLine($"Match history for {summonerData.Name}:");

        //    // Get 10 most recent matches (blocking).
        //    // Queue ID 420 is RANKED_SOLO_5v5 (TODO)
        //    var matchlist = await riotApi.MatchV4.GetMatchlistAsync(
        //        Region.NA, summonerData.AccountId, queue: new[] { 420 }, endIndex: 10);
        //    // Get match results (done asynchronously -> not blocking -> fast).
        //    var matchDataTasks = matchlist.Matches.Select(
        //            matchMetadata => riotApi.MatchV4.GetMatchAsync(Region.NA, matchMetadata.GameId)
        //        ).ToArray();
        //    // Wait for all task requests to complete asynchronously.
        //    var matchDatas = await Task.WhenAll(matchDataTasks);

        //    for (var i = 0; i < matchDatas.Count(); i++)
        //    {
        //        var matchData = matchDatas[i];
        //        // Get this summoner's participant ID info.
        //        var participantIdData = matchData.ParticipantIdentities
        //            .First(pi => summonerData.Id.Equals(pi.Player.SummonerId));
        //        // Find the corresponding participant.
        //        var participant = matchData.Participants
        //            .First(p => p.ParticipantId == participantIdData.ParticipantId);

        //        var win = participant.Stats.Win;
        //        var champ = (Champion) participant.ChampionId;
        //        var k = participant.Stats.Kills;
        //        var d = participant.Stats.Deaths;
        //        var a = participant.Stats.Assists;
        //        var kda = (k + a) / (float) d;

        //        // Print #, win/loss, champion.
        //        Console.WriteLine("{0,3}) {1,-4} ({2})", i + 1, win ? "Win" : "Loss", champ.Name());
        //        // Print champion, K/D/A
        //        Console.WriteLine("     K/D/A {0}/{1}/{2} ({3:0.00})", k, d, a, kda);
        //    }
        //}
    }
}
