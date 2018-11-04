using SportRanker.Feeds.SportRadar.MLB.Contracts;
using SportRanker.Feeds.SportRadar.MLB.Definitions;

namespace SportRanker.Feeds.SportRadar.MLB.Application
{
    public static class ResultConverter
    {
        public static FixtureResult ConvertFromFeedFixtureResult(FeedFixture feedFixture)
        {
            return new FixtureResult()
            {
                SportId = SportId.NBA,
                FeedSource = FeedSource.SportRadar,
                HomeTeamId = feedFixture.HomeTeamId,
                HomeTeamName = feedFixture.HomeTeamName,
                HomeTeamScore = feedFixture.HomeTeamScore,
                AwayTeamId = feedFixture.AwayTeamId,
                AwayTeamName = feedFixture.AwayTeamName,
                AwayTeamScore = feedFixture.AwayTeamScore,
                KickOffTimeUtc = feedFixture.KickOffTimeUtc
            };
        }
    }
}
