using System.Threading.Tasks;

namespace SportRanker.Feeds.SportRadar.MLB.Interfaces
{
    public interface IFeedProcessor
    {
        Task StartProcessing();
        Task ProcessHistoricalFixtures(int days);
    }
}
