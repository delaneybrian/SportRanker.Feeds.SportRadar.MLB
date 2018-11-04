using SportRanker.Feeds.SportRadar.MLB.Contracts;

namespace SportRanker.Feeds.SportRadar.MLB.Interfaces
{
    public interface IPublisher
    {
        void PublishFixtureResult(FixtureResult fixtureResult);
    }
}
