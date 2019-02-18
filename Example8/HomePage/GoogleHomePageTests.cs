using Xunit;

namespace Example8.HomePage
{
    public class GoogleHomePageTests : BaseHomePageTests, IClassFixture<GoogleHomePageFixture>
    {
        
        public GoogleHomePageTests(GoogleHomePageFixture testPageFixture)
        :base(testPageFixture)
        {
        }
    }
}