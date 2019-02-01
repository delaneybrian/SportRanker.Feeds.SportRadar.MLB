using SportRanker.Feeds.SportRadar.MLB.Application.Extensions;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;
using System.Threading.Tasks;

namespace SportRanker.Feeds.SportRadar.MLB.Application
{
    public class FeedProcessor : IFeedProcessor
    {
        private readonly IFeedConsumer _feedConsumer;
        private readonly IPublisher _publisher;
        private readonly IFixtureResultDeriver _fixtureResultDeriver;

        public FeedProcessor(IFeedConsumer feedConsumer,
            IPublisher publisher,
            IFixtureResultDeriver fixtureResultDeriver)
        {
            _feedConsumer = feedConsumer;
            _publisher = publisher;
            _fixtureResultDeriver = fixtureResultDeriver;
        }

        public async Task ProcessHistoricalFixtures(int days)
        {
            var feedResults = await _feedConsumer.GetFixtureResultsForPreviousDaysAsync(days);

            foreach (var feedResult in feedResults)
            {
                var fixtureResultMaybe = await _fixtureResultDeriver.TryGenerateFixtureResult(feedResult);

                if (fixtureResultMaybe.TrySome(out var fixtureResult))
                    _publisher.PublishFixtureResult(fixtureResult);
            }
        }

        public async Task StartProcessing()
        {
            var feedResults = await _feedConsumer.GetFixtureResultsForPreviousDaysAsync(8);

            foreach (var feedResult in feedResults)
            {
                var fixtureResultMaybe = await _fixtureResultDeriver.TryGenerateFixtureResult(feedResult);

                if (fixtureResultMaybe.TrySome(out var fixtureResult))
                    _publisher.PublishFixtureResult(fixtureResult);
            }
        }
    }
}
