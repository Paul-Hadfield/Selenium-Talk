using Xunit;

namespace Example8.HomePage
{
    public class DuckDuckGoHomePageTests : BaseHomePageTests, IClassFixture<DuckDuckGoHomePageFixture>
    {
        
        public DuckDuckGoHomePageTests(DuckDuckGoHomePageFixture testPageFixture)
        :base(testPageFixture)
        {
        }
    }
}