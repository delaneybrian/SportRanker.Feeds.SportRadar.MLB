using Optional;
using SportRanker.Contracts.Dto;
using System.Threading.Tasks;

namespace SportRanker.Feeds.SportRadar.MLB.Interfaces
{
    public interface IDataProvider
    {
        Task<Option<Team>> GetTeamByProviderIdAsync(SourceId provider, string providerId);
        Task<Option<Fixture>> GetFixtureByProviderIdAsync(SourceId provider, string providerId);
    }
}
