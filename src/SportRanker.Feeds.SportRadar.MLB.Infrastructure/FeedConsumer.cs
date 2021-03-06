﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SportRanker.Contracts.Dto;
using SportRanker.Feeds.SportRadar.MLB.Definitions;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;

namespace SportRanker.Feeds.SportRadar.MLB.Infrastructure
{
    public class FeedConsumer : IFeedConsumer
    {
        private readonly HttpClient _httpClient;

        private readonly string ApiKey = "juf6evz79agmrbw8w4a9vqbm";

        private readonly int DaysInYear = 365;

        public FeedConsumer()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ICollection<FeedFixture>> GetFixtureResultsForYesterdayAsync()
        {
            ICollection<FeedFixture> feedFixtures = new List<FeedFixture>();

            var yesterday = DateTime.UtcNow.AddDays(-1);

            var url = $"https://api.sportradar.us/mlb-t6/games/{yesterday.Year}/{yesterday.Month}/{yesterday.Day}/summary.json?api_key={ApiKey}";

            var result = await _httpClient.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();

                DefaultContractResolver contractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };

                var feedSchedule = JsonConvert.DeserializeObject<FeedSchedule>(content, new JsonSerializerSettings
                {
                    ContractResolver = contractResolver,
                    Formatting = Formatting.Indented
                });

                if (feedSchedule.league.games == null)
                    return feedFixtures;

                foreach (var game in feedSchedule.league.games)
                {
                    var fixture = game.game;

                    if (fixture.status == "closed")
                    {
                        feedFixtures.Add(
                            new FeedFixture()
                            {
                                FeedSource = SourceId.SportRadar,
                                ProviderFixtureId = fixture.id,
                                KickOffTimeUtc = fixture.scheduled,
                                HomeTeamId = fixture.home.id,
                                HomeTeamName = fixture.home.name,
                                HomeTeamScore = fixture.home.runs,
                                AwayTeamId = fixture.away.id,
                                AwayTeamName = fixture.away.name,
                                AwayTeamScore = fixture.away.runs
                            });
                    }
                }
            }

            return feedFixtures;
        }

        public async Task<ICollection<FeedFixture>> GetFixtureResultsForPreviousDaysAsync(int numDays)
        {
            ICollection<FeedFixture> feedFixtures = new List<FeedFixture>();

            if (numDays > DaysInYear)
                numDays = DaysInYear;

            if (numDays > 0)
                numDays = numDays * -1;

            while (numDays < 0)
            {
                var day = DateTime.UtcNow.AddDays(numDays);

                var url = $"https://api.sportradar.us/mlb-t6/games/{day.Year}/{day.Month}/{day.Day}/summary.json?api_key={ApiKey}";

                var result = await _httpClient.GetAsync(url);

                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();

                    DefaultContractResolver contractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    };

                    var feedSchedule = JsonConvert.DeserializeObject<FeedSchedule>(content, new JsonSerializerSettings
                    {
                        ContractResolver = contractResolver,
                        Formatting = Formatting.Indented
                    });

                    if (feedSchedule.league.games == null)
                        return feedFixtures;

                    foreach (var game in feedSchedule.league.games)
                    {
                        var fixture = game.game;

                        if (fixture.status == "closed")
                        {
                            feedFixtures.Add(
                                new FeedFixture()
                                {
                                    FeedSource = SourceId.SportRadar,
                                    ProviderFixtureId = fixture.id,
                                    KickOffTimeUtc = fixture.scheduled,
                                    HomeTeamId = fixture.home.id,
                                    HomeTeamName = fixture.home.name,
                                    HomeTeamScore = fixture.home.runs,
                                    AwayTeamId = fixture.away.id,
                                    AwayTeamName = fixture.away.name,
                                    AwayTeamScore = fixture.away.runs
                                });
                        }
                    }
                }
                numDays += 1;

                Thread.Sleep(2000);
            }
            return feedFixtures;
        }
    }
}
