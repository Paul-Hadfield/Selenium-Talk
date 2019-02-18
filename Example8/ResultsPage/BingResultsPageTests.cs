using Xunit;

namespace Example8.ResultsPage
{
    public class BingResultsPageTests : BaseResultsPageTests, IClassFixture<BingResultsFixture>
    {
        
        public BingResultsPageTests(BingResultsFixture testFixture)
        :base(testFixture)
        {
        }
    }
}