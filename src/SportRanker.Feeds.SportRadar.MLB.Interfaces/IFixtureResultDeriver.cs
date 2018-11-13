using Optional;
using SportRanker.Contracts.SystemEvents;
using SportRanker.Feeds.SportRadar.MLB.Definitions;
using System.Threading.Tasks;

namespace SportRanker.Feeds.SportRadar.MLB.Interfaces
{
    public interface IFixtureResultDeriver
    {
        Task<Option<FixtureResult>> TryGenerateFixtureResult(FeedFixture feedFixture);
    }
}
