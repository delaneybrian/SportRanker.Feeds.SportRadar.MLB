using SportRanker.Contracts.SystemEvents;

namespace SportRanker.Feeds.SportRadar.MLB.Interfaces
{
    public interface IPublisher
    {
        void PublishFixtureResult(FixtureResult fixtureResult);
    }
}
