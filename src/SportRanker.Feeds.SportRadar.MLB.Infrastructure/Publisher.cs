﻿using System;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using SportRanker.Feeds.SportRadar.MLB.Contracts;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;

namespace SportRanker.Feeds.SportRadar.MLB.Infrastructure
{
    public class Publisher : IPublisher
    {
        private const string NewFixtureExchange = "new_fixture_exchange";

        private const string NewMLBFixtureRoutingKey = "results.mlb";

        public void PublishFixtureResult(FixtureResult fixtureResult)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(
                    exchange: NewFixtureExchange,
                    type: "topic");

                var message = JsonConvert.SerializeObject(fixtureResult);

                var body = Encoding.UTF8.GetBytes(message);

                try
                {
                    channel.BasicPublish(exchange: NewFixtureExchange,
                        routingKey: NewMLBFixtureRoutingKey,
                        basicProperties: null,
                        body: body);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Could Not Publish To Queue");
                }
            }
        }
    }
}
