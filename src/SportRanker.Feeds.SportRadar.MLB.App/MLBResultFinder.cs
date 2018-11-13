using System;
using Autofac;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using SportRanker.Feeds.SportRadar.MLB.Interfaces;

namespace SportRanker.Feeds.SportRadar.MLB.App
{
    public static class MLBResultFinder
    {
        [FunctionName("MLBResultFinder")]
        public static void Run([TimerTrigger("0 0 20 * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C#" +
                $" Timer trigger function executed at: {DateTime.Now}");

            var container = AppBootstrapper.Bootstrap();

            var feedProcessor = container.Resolve<IFeedProcessor>();

            feedProcessor.StartProcessing().Wait();
        }
    }
}
