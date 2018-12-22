using SportRanker.Contracts.SystemEvents;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace SportRanker.Feeds.SportRadar.MLB.Infrastructure
{
    public class FilePublisher : IPublisher
    {
        private string fileLocation = @"C:/Fixtures/mlb.txt";

        public void PublishFixtureResult(FixtureResult fixtureResult)
        {
            var json = JsonConvert.SerializeObject(fixtureResult);

            using (StreamWriter writer = File.AppendText(fileLocation))
            {
                writer.WriteLine(json);
            }
        }
    }
}
