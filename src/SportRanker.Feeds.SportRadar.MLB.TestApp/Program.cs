using Autofac;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;

namespace SportRanker.Feeds.SportRadar.MLB.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AppBootstrapper.Bootstrap();

            var feedProcessor = container.Resolve<IFeedProcessor>();

            feedProcessor.ProcessHistoricalFixtures(3).Wait();
        }
    }
}
