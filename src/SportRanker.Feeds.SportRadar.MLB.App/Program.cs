using System;
using System.Threading.Tasks;
using Autofac;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;

namespace SportRanker.Feeds.SportRadar.MLB.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = AppBootstrapper.Bootstrap();

            var feedProcessor = container.Resolve<IFeedProcessor>();

            Task.Run(() => feedProcessor.StartProcessing());

            Console.ReadKey();
        }
    }
}
