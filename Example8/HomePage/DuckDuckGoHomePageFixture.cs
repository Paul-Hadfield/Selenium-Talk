using Example8.PageObjects.HomePage;

namespace Example8.HomePage
{
    public class DuckDuckGoHomePageFixture : BaseHomePageFixture
    {
        public DuckDuckGoHomePageFixture()
        {
            this.Page = DuckDuckGoHomePageObject
                .Load(this.driver);
        }
        
    }
}