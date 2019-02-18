using Xunit;

namespace Example8.ResultsPage
{
    public class GoogleResultsPageTests : BaseResultsPageTests, IClassFixture<GoogleResultsFixture>
    {
        
        public GoogleResultsPageTests(GoogleResultsFixture testFixture)
        :base(testFixture)
        {
        }
    }
}