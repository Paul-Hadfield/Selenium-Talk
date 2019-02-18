using Example8.PageObjects.HomePage;

namespace Example8.ResultsPage
{
    public class DuckDuckGoResultsFixture : BaseResultsPageFixture
    {
        public DuckDuckGoResultsFixture()
        {
            this.Page = DuckDuckGoHomePageObject
                .Load(this.driver).Search("Cheese");
        }
        
    }
}