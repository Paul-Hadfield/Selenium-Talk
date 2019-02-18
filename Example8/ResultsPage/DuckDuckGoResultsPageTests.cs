using Xunit;

namespace Example8.ResultsPage
{
    public class DuckDuckGoResultsPageTests : BaseResultsPageTests, IClassFixture<DuckDuckGoResultsFixture>
    {
        
        public DuckDuckGoResultsPageTests(DuckDuckGoResultsFixture testFixture)
        :base(testFixture)
        {
        }
    }
}