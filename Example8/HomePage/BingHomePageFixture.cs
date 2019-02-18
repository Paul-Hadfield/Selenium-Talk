using Example8.PageObjects.HomePage;

namespace Example8.HomePage
{
    public class BingHomePageFixture : BaseHomePageFixture
    {
        public BingHomePageFixture()
        {
            this.Page = BingHomePageObject
                .Load(this.driver);
        }
        
    }
}