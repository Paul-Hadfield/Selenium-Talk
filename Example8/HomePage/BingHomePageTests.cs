using Example8.PageObjects.HomePage;
using Xunit;

namespace Example8.HomePage
{
    public class BingHomePageTests : BaseHomePageTests, IClassFixture<BingHomePageFixture>
    {
        
        public BingHomePageTests(BingHomePageFixture testPageFixture)
            :base(testPageFixture)
        {
        }

        [Fact]
        public void BingLogoShown()
        {
            this.testFixture.RunAssert(() => Assert.True(((BingHomePageObject)this.testFixture.Page).BingLogoShown()));
        }
    }
}